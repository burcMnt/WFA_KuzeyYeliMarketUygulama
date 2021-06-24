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
    public partial class KategoriDuzenle : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=KuzeyYeli; uid=sa; pwd=123");
        public Kategori Kategori { get; set; }
        public KategoriDuzenle()
        {
            con.Open();
            InitializeComponent();
        }

        public KategoriDuzenle(Kategori kategori)
        {
            con.Open();
            InitializeComponent();
            Kategori = kategori;
            txtKategoriId.Text = Kategori.KategoriId.ToString();
            txtKategoriAd.Text = Kategori.KategoriAd;
        }

        private void btnUrunTamam_Click(object sender, EventArgs e)
        {
            string ad = txtKategoriAd.Text.Trim();
            if (txtKategoriId.Text.Length <= 0)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Kategoriler(KategoriAd) VALUES(@p1)", con);
                cmd.Parameters.AddWithValue("@p1", ad);
                cmd.ExecuteNonQuery();
                txtKategoriAd.Clear();
                txtKategoriId.Clear();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string yeniAd = txtKategoriAd.Text.Trim();
                var cmd = new SqlCommand("UPDATE Kategoriler SET KategoriAd = @p1 WHERE KategoriId = @p2", con);
                cmd.Parameters.AddWithValue("@p1", yeniAd);
                cmd.Parameters.AddWithValue("@p2", Kategori.KategoriId);
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnUrunIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
