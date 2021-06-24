
namespace KuzeyYeliTR
{
    partial class KategoriDuzenle
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
            this.btnUrunIptal = new System.Windows.Forms.Button();
            this.btnUrunTamam = new System.Windows.Forms.Button();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUrunIptal
            // 
            this.btnUrunIptal.Location = new System.Drawing.Point(212, 118);
            this.btnUrunIptal.Name = "btnUrunIptal";
            this.btnUrunIptal.Size = new System.Drawing.Size(119, 23);
            this.btnUrunIptal.TabIndex = 25;
            this.btnUrunIptal.Text = "IPTAL";
            this.btnUrunIptal.UseVisualStyleBackColor = true;
            this.btnUrunIptal.Click += new System.EventHandler(this.btnUrunIptal_Click);
            // 
            // btnUrunTamam
            // 
            this.btnUrunTamam.Location = new System.Drawing.Point(42, 118);
            this.btnUrunTamam.Name = "btnUrunTamam";
            this.btnUrunTamam.Size = new System.Drawing.Size(154, 23);
            this.btnUrunTamam.TabIndex = 24;
            this.btnUrunTamam.Text = "TAMAM";
            this.btnUrunTamam.UseVisualStyleBackColor = true;
            this.btnUrunTamam.Click += new System.EventHandler(this.btnUrunTamam_Click);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(162, 74);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(172, 22);
            this.txtKategoriAd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kategori Ad :";
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(162, 34);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.ReadOnly = true;
            this.txtKategoriId.Size = new System.Drawing.Size(172, 22);
            this.txtKategoriId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kategori Id :";
            // 
            // KategoriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 200);
            this.Controls.Add(this.btnUrunIptal);
            this.Controls.Add(this.btnUrunTamam);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriId);
            this.Controls.Add(this.label1);
            this.Name = "KategoriDuzenle";
            this.Text = "Kategori Duzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunIptal;
        private System.Windows.Forms.Button btnUrunTamam;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.Label label1;
    }
}