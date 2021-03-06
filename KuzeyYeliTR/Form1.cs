using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeliTR
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=KuzeyYeli; uid=sa; pwd=123");
        public Form1()
        {
            con.Open();
            InitializeComponent();
            dgvUrunler.AutoGenerateColumns = false; // oto sütün oluşturmayı durdur
            KategorileriYukle();
        }

        private void KategorileriYukle()
        {
            var cmd = new SqlCommand("SELECT KategoriId, KategoriAd FROM Kategoriler", con);
            var dr = cmd.ExecuteReader();
            var lst = new List<Kategori>();
            while (dr.Read())
            {
                lst.Add(new Kategori()
                {
                    KategoriId = (int)dr["KategoriId"],
                    KategoriAd = (string)dr["KategoriAd"],
                });
            }
            dr.Close();
            lstKategoriler.DataSource = lst;
        }

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex == -1)
            {
                dgvUrunler.DataSource = null;
                return;
            }

            Kategori seciliKategori = (Kategori)lstKategoriler.SelectedItem;
            UrunleriListele(seciliKategori.KategoriId);

        }

        private void UrunleriListele(int kategoriId)
        {
            var cmd = new SqlCommand(
                "SELECT Id, UrunAd, BirimFiyat, StokAdet,KategoriId,Resim FROM Urunler " +
                "WHERE KategoriId = @p1", con);
            cmd.Parameters.AddWithValue("@p1", kategoriId);
            var dr = cmd.ExecuteReader();

            var lst = new List<Urunler>();
            while (dr.Read())
            {
                lst.Add(new Urunler()
                {
                    UrunId = (int)dr["Id"],
                    UrunAd = (string)dr["UrunAd"],
                    BirimFiyat = (decimal)dr["BirimFiyat"],
                    StokAdet = (int)dr["StokAdet"],
                    KategoriId=(int)dr["KategoriId"],
                    Resim=dr[5] is DBNull ? null : (byte[])dr[5]

                });
            }
            dr.Close();
            dgvUrunler.DataSource = lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriDuzenle frm = new KategoriDuzenle();
            DialogResult cevap = frm.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                KategorileriYukle();
                KategoriyiSec(frm.SonEklenenId);
            }

        }

        private void KategoriyiSec(int sonEklenenId)
        {
            for (int i = 0; i < lstKategoriler.Items.Count; i++)
            {
                Kategori kat = (Kategori)lstKategoriler.Items[i];

                if (kat.KategoriId == sonEklenenId)
                {
                    lstKategoriler.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            DialogResult cevap = new UrunDuzenle().ShowDialog();
            if (cevap == DialogResult.OK)
            {
                Kategori seciliKategori = (Kategori)lstKategoriler.SelectedItem;
                UrunleriListele(seciliKategori.KategoriId);
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {

            if (lstKategoriler.SelectedIndex > -1)
            {
                Kategori kategori1 = (Kategori)lstKategoriler.SelectedItem;
                SqlCommand cmd = new SqlCommand("DELETE FROM Kategoriler WHERE KategoriId = @id", con);
                cmd.Parameters.AddWithValue("@id", kategori1.KategoriId);
                cmd.ExecuteNonQuery();
            }
            KategorileriYukle();
        }

        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex > -1)
            {
                Kategori secilenKategori = (Kategori)lstKategoriler.SelectedItem;
                DialogResult cevap = new KategoriDuzenle(secilenKategori).ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    KategorileriYukle();
                    lstKategoriler.SelectedIndex = lstKategoriler.Items.Count - 1;
                }
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                Urunler secilenUrun = (Urunler)dgvUrunler.SelectedRows[0].DataBoundItem;
                UrunDuzenle urunDuzenle = new UrunDuzenle(secilenUrun);
                urunDuzenle.ShowDialog();
            }

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count != 0)
            {
                Urunler urunler = (Urunler)dgvUrunler.SelectedRows[0].DataBoundItem;
                SqlCommand cmd = new SqlCommand("DELETE FROM Urunler WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", urunler.UrunId);
                cmd.ExecuteNonQuery();
            }
            Kategori seciliKategori = (Kategori)lstKategoriler.SelectedItem;
           // KategorileriYukle();
            UrunleriListele(seciliKategori.KategoriId);
        }
    }
}
