
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
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pboUrunResim = new System.Windows.Forms.PictureBox();
            this.btnResimDüzenle = new System.Windows.Forms.Button();
            this.btnUrunTamam = new System.Windows.Forms.Button();
            this.btnUrunIptal = new System.Windows.Forms.Button();
            this.cboUrunKategori = new System.Windows.Forms.ComboBox();
            this.kuzeyYeliDataSet = new KuzeyYeliTR.KuzeyYeliDataSet();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter = new KuzeyYeliTR.KuzeyYeliDataSetTableAdapters.KategorilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrunResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Id :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(171, 52);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(172, 22);
            this.txtUrunId.TabIndex = 1;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(171, 92);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(172, 22);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Ad :";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(171, 131);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(172, 22);
            this.txtUrunFiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Fiyat :";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(171, 175);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(172, 22);
            this.txtUrunStok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kategori :";
            // 
            // pboUrunResim
            // 
            this.pboUrunResim.Location = new System.Drawing.Point(431, 52);
            this.pboUrunResim.Name = "pboUrunResim";
            this.pboUrunResim.Size = new System.Drawing.Size(189, 145);
            this.pboUrunResim.TabIndex = 10;
            this.pboUrunResim.TabStop = false;
            // 
            // btnResimDüzenle
            // 
            this.btnResimDüzenle.Location = new System.Drawing.Point(431, 214);
            this.btnResimDüzenle.Name = "btnResimDüzenle";
            this.btnResimDüzenle.Size = new System.Drawing.Size(189, 23);
            this.btnResimDüzenle.TabIndex = 11;
            this.btnResimDüzenle.Text = "DÜZENLE";
            this.btnResimDüzenle.UseVisualStyleBackColor = true;
            // 
            // btnUrunTamam
            // 
            this.btnUrunTamam.Location = new System.Drawing.Point(54, 264);
            this.btnUrunTamam.Name = "btnUrunTamam";
            this.btnUrunTamam.Size = new System.Drawing.Size(154, 23);
            this.btnUrunTamam.TabIndex = 12;
            this.btnUrunTamam.Text = "TAMAM";
            this.btnUrunTamam.UseVisualStyleBackColor = true;
            this.btnUrunTamam.Click += new System.EventHandler(this.btnUrunTamam_Click);
            // 
            // btnUrunIptal
            // 
            this.btnUrunIptal.Location = new System.Drawing.Point(224, 264);
            this.btnUrunIptal.Name = "btnUrunIptal";
            this.btnUrunIptal.Size = new System.Drawing.Size(119, 23);
            this.btnUrunIptal.TabIndex = 13;
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
            this.cboUrunKategori.TabIndex = 14;
            this.cboUrunKategori.ValueMember = "KategoriId";
            // 
            // kuzeyYeliDataSet
            // 
            this.kuzeyYeliDataSet.DataSetName = "KuzeyYeliDataSet";
            this.kuzeyYeliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.kuzeyYeliDataSet;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // UrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 355);
            this.Controls.Add(this.cboUrunKategori);
            this.Controls.Add(this.btnUrunIptal);
            this.Controls.Add(this.btnUrunTamam);
            this.Controls.Add(this.btnResimDüzenle);
            this.Controls.Add(this.pboUrunResim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrunStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.label1);
            this.Name = "UrunDuzenle";
            this.Text = "Urun Ekle / Duzenle";
            this.Load += new System.EventHandler(this.UrunDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboUrunResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pboUrunResim;
        private System.Windows.Forms.Button btnResimDüzenle;
        private System.Windows.Forms.Button btnUrunTamam;
        private System.Windows.Forms.Button btnUrunIptal;
        private System.Windows.Forms.ComboBox cboUrunKategori;
        private KuzeyYeliDataSet kuzeyYeliDataSet;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private KuzeyYeliDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
    }
}