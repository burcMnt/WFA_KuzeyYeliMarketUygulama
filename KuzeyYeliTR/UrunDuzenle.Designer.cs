
namespace KuzeyYeliTR
{
    partial class UrunDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                con.Close();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pboResim = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnUrunTamam = new System.Windows.Forms.Button();
            this.btnUrunIptal = new System.Windows.Forms.Button();
            this.cboUrunKategori = new System.Windows.Forms.ComboBox();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuzeyYeliDataSet = new KuzeyYeliTR.KuzeyYeliDataSet();
            this.kategorilerTableAdapter = new KuzeyYeliTR.KuzeyYeliDataSetTableAdapters.KategorilerTableAdapter();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.nudStokAdet = new System.Windows.Forms.NumericUpDown();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün Id :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(171, 52);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(172, 22);
            this.txtUrunId.TabIndex = 12;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(171, 92);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(172, 22);
            this.txtUrunAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kategori :";
            // 
            // pboResim
            // 
            this.pboResim.BackColor = System.Drawing.Color.White;
            this.pboResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboResim.Location = new System.Drawing.Point(374, 52);
            this.pboResim.Name = "pboResim";
            this.pboResim.Size = new System.Drawing.Size(246, 179);
            this.pboResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboResim.TabIndex = 10;
            this.pboResim.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(374, 264);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(189, 23);
            this.btnResimSec.TabIndex = 9;
            this.btnResimSec.Text = "DÜZENLE";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnUrunTamam
            // 
            this.btnUrunTamam.Location = new System.Drawing.Point(54, 264);
            this.btnUrunTamam.Name = "btnUrunTamam";
            this.btnUrunTamam.Size = new System.Drawing.Size(154, 23);
            this.btnUrunTamam.TabIndex = 8;
            this.btnUrunTamam.Text = "KAYDET";
            this.btnUrunTamam.UseVisualStyleBackColor = true;
            this.btnUrunTamam.Click += new System.EventHandler(this.btnUrunTamam_Click);
            // 
            // btnUrunIptal
            // 
            this.btnUrunIptal.Location = new System.Drawing.Point(224, 264);
            this.btnUrunIptal.Name = "btnUrunIptal";
            this.btnUrunIptal.Size = new System.Drawing.Size(119, 23);
            this.btnUrunIptal.TabIndex = 10;
            this.btnUrunIptal.Text = "IPTAL";
            this.btnUrunIptal.UseVisualStyleBackColor = true;
            this.btnUrunIptal.Click += new System.EventHandler(this.btnUrunIptal_Click);
            // 
            // cboUrunKategori
            // 
            this.cboUrunKategori.DataSource = this.kategorilerBindingSource;
            this.cboUrunKategori.DisplayMember = "KategoriId";
            this.cboUrunKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrunKategori.FormattingEnabled = true;
            this.cboUrunKategori.Location = new System.Drawing.Point(171, 210);
            this.cboUrunKategori.Name = "cboUrunKategori";
            this.cboUrunKategori.Size = new System.Drawing.Size(172, 24);
            this.cboUrunKategori.TabIndex = 7;
            this.cboUrunKategori.ValueMember = "KategoriId";
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.kuzeyYeliDataSet;
            // 
            // kuzeyYeliDataSet
            // 
            this.kuzeyYeliDataSet.DataSetName = "KuzeyYeliDataSet";
            this.kuzeyYeliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.DecimalPlaces = 2;
            this.nudBirimFiyat.Location = new System.Drawing.Point(171, 131);
            this.nudBirimFiyat.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(172, 22);
            this.nudBirimFiyat.TabIndex = 3;
            // 
            // nudStokAdet
            // 
            this.nudStokAdet.Location = new System.Drawing.Point(171, 175);
            this.nudStokAdet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStokAdet.Name = "nudStokAdet";
            this.nudStokAdet.Size = new System.Drawing.Size(172, 22);
            this.nudStokAdet.TabIndex = 5;
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "openFileDialog1";
            this.ofdResim.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // UrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 355);
            this.Controls.Add(this.nudStokAdet);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.cboUrunKategori);
            this.Controls.Add(this.btnUrunIptal);
            this.Controls.Add(this.btnUrunTamam);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pboResim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.label1);
            this.Name = "UrunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Urun Ekle / Duzenle";
            this.Load += new System.EventHandler(this.UrunDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pboResim;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnUrunTamam;
        private System.Windows.Forms.Button btnUrunIptal;
        private System.Windows.Forms.ComboBox cboUrunKategori;
        private KuzeyYeliDataSet kuzeyYeliDataSet;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private KuzeyYeliDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private System.Windows.Forms.NumericUpDown nudBirimFiyat;
        private System.Windows.Forms.NumericUpDown nudStokAdet;
        private System.Windows.Forms.OpenFileDialog ofdResim;
    }
}