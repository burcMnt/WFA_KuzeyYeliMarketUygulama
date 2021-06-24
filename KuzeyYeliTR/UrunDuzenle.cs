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
    public partial class UrunDuzenle : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=KuzeyYeli; uid=sa; pwd=123");
        public Urunler Urun { get; set; }
        public UrunDuzenle()
        {
            con.Open();
            InitializeComponent();
        }
        public UrunDuzenle(Urunler urun)
        {
            con.Open();
            InitializeComponent();
            Urun = urun;
            txtUrunId.Text = Urun.UrunId.ToString();
            txtUrunAd.Text = Urun.UrunAd;
            txtUrunFiyat.Text = Urun.BirimFiyat.ToString();
            txtUrunStok.Text = Urun.StokAdet.ToString();
        }

        private void btnUrunTamam_Click(object sender, EventArgs e)
        {
            string ad = txtUrunAd.Text.Trim();
            string fiyat = txtUrunFiyat.Text.Trim();
            string stok = txtUrunStok.Text.Trim();
            int kategori = Convert.ToInt32(cboUrunKategori.Text);
            if (txtUrunId.Text.Length <= 0)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Urunler(KategoriId, UrunAd, BirimFiyat, StokAdet ) VALUES(@p1,@p2,@p3,@p4)", con);
                cmd.Parameters.AddWithValue("@p1", kategori);
                cmd.Parameters.AddWithValue("@p2", ad);
                cmd.Parameters.AddWithValue("@p3", fiyat);
                cmd.Parameters.AddWithValue("@p4", stok);
                cmd.ExecuteNonQuery();
                txtUrunId.Clear();
                txtUrunAd.Clear();
                txtUrunFiyat.Clear();
                txtUrunStok.Clear();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {

                string yeniAd = txtUrunAd.Text.Trim();
                decimal yeniFiyat = Convert.ToDecimal(txtUrunFiyat.Text.Trim());
                int yeniStok = Convert.ToInt32(txtUrunStok.Text.Trim());
                int yeniKategori = Convert.ToInt32(cboUrunKategori.SelectedIndex + 1);
                var cmd = new SqlCommand("UPDATE Urunler SET KategoriId= @p1, UrunAd = @p2,BirimFiyat = @p3, StokAdet = @p4 WHERE Id = @p5", con);
                cmd.Parameters.AddWithValue("@p1", yeniKategori);
                cmd.Parameters.AddWithValue("@p2", yeniAd);
                cmd.Parameters.AddWithValue("@p3", yeniFiyat);
                cmd.Parameters.AddWithValue("@p4", yeniStok);
                cmd.Parameters.AddWithValue("@p5", Urun.UrunId);
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
            }
        }

        private void UrunDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kuzeyYeliDataSet.Kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter.Fill(this.kuzeyYeliDataSet.Kategoriler);

        }

        private void btnUrunIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
