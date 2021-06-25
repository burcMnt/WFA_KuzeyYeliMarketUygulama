using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            nudBirimFiyat.Value = Urun.BirimFiyat;
            nudStokAdet.Value = (decimal)Urun.StokAdet;
            Urun.Resim = ImageToByteArray(pboResim.Image);
            pboResim.Image = urun.ResmiGetir();
        }

        private void btnUrunTamam_Click(object sender, EventArgs e)
        {
            string ad = txtUrunAd.Text.Trim();
            decimal fiyat = nudBirimFiyat.Value;
            decimal stok = nudStokAdet.Value;
            int kategori = Convert.ToInt32(cboUrunKategori.Text);
            byte[] resim = ImageToByteArray(pboResim.Image);
            if (ad == "" || fiyat == null || stok == null)
            {
                MessageBox.Show("Önce boş kısımları doldurmalısınız..");
                return;
            }
            if (txtUrunId.Text.Length <= 0)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Urunler(KategoriId, UrunAd, BirimFiyat, StokAdet, Resim ) VALUES(@p1,@p2,@p3,@p4,@p5)", con);
                cmd.Parameters.AddWithValue("@p1", kategori);
                cmd.Parameters.AddWithValue("@p2", ad);
                cmd.Parameters.AddWithValue("@p3", fiyat);
                cmd.Parameters.AddWithValue("@p4", stok);
                cmd.Parameters.AddWithValue("@p5", resim);
                cmd.ExecuteNonQuery();
                txtUrunId.Clear();
                txtUrunAd.Clear();

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {

                string yeniAd = txtUrunAd.Text.Trim();
                decimal yeniFiyat = nudBirimFiyat.Value;
                decimal yeniStok = nudStokAdet.Value;
                int yeniKategori = Convert.ToInt32(cboUrunKategori.Text);
                byte[] yeniResim = ImageToByteArray(pboResim.Image);
                var cmd = new SqlCommand("UPDATE Urunler SET KategoriId= @p1, UrunAd = @p2,BirimFiyat = @p3, StokAdet = @p4, Resim =@p5 WHERE Id = @p6", con);
                cmd.Parameters.AddWithValue("@p1", yeniKategori);
                cmd.Parameters.AddWithValue("@p2", yeniAd);
                cmd.Parameters.AddWithValue("@p3", yeniFiyat);
                cmd.Parameters.AddWithValue("@p4", yeniStok);
                cmd.Parameters.AddWithValue("@p5", yeniResim);
                cmd.Parameters.AddWithValue("@p6", Urun.UrunId);
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
            }
        }
        // https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
        public byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
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

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdResim.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pboResim.Image = Image.FromFile(ofdResim.FileName);
            }

            // Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0
        }
    }
}
