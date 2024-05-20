namespace HRS_Desktop
{
    partial class CalisanGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanGirisForm));
            this.yardimBTN = new System.Windows.Forms.Button();
            this.geriBTN = new System.Windows.Forms.Button();
            this.cikisBTN = new System.Windows.Forms.Button();
            this.hastaKayitFormBTN = new System.Windows.Forms.Button();
            this.randevuIslemFormBTN = new System.Windows.Forms.Button();
            this.kullaniciIslemFormBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yardimBTN
            // 
            this.yardimBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.yardimBTN.Location = new System.Drawing.Point(364, 645);
            this.yardimBTN.Name = "yardimBTN";
            this.yardimBTN.Size = new System.Drawing.Size(346, 65);
            this.yardimBTN.TabIndex = 5;
            this.yardimBTN.Text = "Yardım";
            this.yardimBTN.UseVisualStyleBackColor = true;
            this.yardimBTN.Click += new System.EventHandler(this.yardimBTN_Click);
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.geriBTN.Location = new System.Drawing.Point(12, 645);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(346, 65);
            this.geriBTN.TabIndex = 4;
            this.geriBTN.Text = "Geri";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // cikisBTN
            // 
            this.cikisBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cikisBTN.Location = new System.Drawing.Point(716, 645);
            this.cikisBTN.Name = "cikisBTN";
            this.cikisBTN.Size = new System.Drawing.Size(346, 65);
            this.cikisBTN.TabIndex = 6;
            this.cikisBTN.Text = "Çıkış";
            this.cikisBTN.UseVisualStyleBackColor = true;
            this.cikisBTN.Click += new System.EventHandler(this.cikisBTN_Click);
            // 
            // hastaKayitFormBTN
            // 
            this.hastaKayitFormBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.hastaKayitFormBTN.Image = global::HRS_Desktop.Properties.Resources.HastaKayıtButtonPNG;
            this.hastaKayitFormBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hastaKayitFormBTN.Location = new System.Drawing.Point(12, 12);
            this.hastaKayitFormBTN.Name = "hastaKayitFormBTN";
            this.hastaKayitFormBTN.Size = new System.Drawing.Size(1050, 205);
            this.hastaKayitFormBTN.TabIndex = 1;
            this.hastaKayitFormBTN.UseVisualStyleBackColor = true;
            this.hastaKayitFormBTN.Click += new System.EventHandler(this.hastaKayitFormBTN_Click);
            // 
            // randevuIslemFormBTN
            // 
            this.randevuIslemFormBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.randevuIslemFormBTN.Image = global::HRS_Desktop.Properties.Resources.RandevuIslemButtonPNG;
            this.randevuIslemFormBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevuIslemFormBTN.Location = new System.Drawing.Point(12, 434);
            this.randevuIslemFormBTN.Name = "randevuIslemFormBTN";
            this.randevuIslemFormBTN.Size = new System.Drawing.Size(1050, 205);
            this.randevuIslemFormBTN.TabIndex = 3;
            this.randevuIslemFormBTN.UseVisualStyleBackColor = true;
            this.randevuIslemFormBTN.Click += new System.EventHandler(this.randevuIslemFormBTN_Click);
            // 
            // kullaniciIslemFormBTN
            // 
            this.kullaniciIslemFormBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.kullaniciIslemFormBTN.Image = global::HRS_Desktop.Properties.Resources.KullaniciIslemButtonPNG;
            this.kullaniciIslemFormBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullaniciIslemFormBTN.Location = new System.Drawing.Point(12, 223);
            this.kullaniciIslemFormBTN.Name = "kullaniciIslemFormBTN";
            this.kullaniciIslemFormBTN.Size = new System.Drawing.Size(1050, 205);
            this.kullaniciIslemFormBTN.TabIndex = 2;
            this.kullaniciIslemFormBTN.UseVisualStyleBackColor = true;
            this.kullaniciIslemFormBTN.Click += new System.EventHandler(this.kullaniciIslemFormBTN_Click);
            // 
            // CalisanGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 720);
            this.Controls.Add(this.cikisBTN);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.yardimBTN);
            this.Controls.Add(this.kullaniciIslemFormBTN);
            this.Controls.Add(this.randevuIslemFormBTN);
            this.Controls.Add(this.hastaKayitFormBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalisanGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem seçim ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalisanGiris_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button yardimBTN;
        private System.Windows.Forms.Button geriBTN;
        private System.Windows.Forms.Button cikisBTN;
        private System.Windows.Forms.Button hastaKayitFormBTN;
        private System.Windows.Forms.Button randevuIslemFormBTN;
        private System.Windows.Forms.Button kullaniciIslemFormBTN;
    }
}