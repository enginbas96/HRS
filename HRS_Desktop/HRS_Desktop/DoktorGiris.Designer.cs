namespace HRS_Desktop
{
    partial class DoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGiris));
            this.cikisBTN = new System.Windows.Forms.Button();
            this.geriBTN = new System.Windows.Forms.Button();
            this.yardimBTN = new System.Windows.Forms.Button();
            this.randevuIslemleriBTN = new System.Windows.Forms.Button();
            this.receteIslemleriBTN = new System.Windows.Forms.Button();
            this.kullaniciIslemleriBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // randevuIslemleriBTN
            // 
            this.randevuIslemleriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.randevuIslemleriBTN.Image = global::HRS_Desktop.Properties.Resources.RandevuIslemButtonPNG;
            this.randevuIslemleriBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevuIslemleriBTN.Location = new System.Drawing.Point(12, 434);
            this.randevuIslemleriBTN.Name = "randevuIslemleriBTN";
            this.randevuIslemleriBTN.Size = new System.Drawing.Size(1050, 205);
            this.randevuIslemleriBTN.TabIndex = 3;
            this.randevuIslemleriBTN.UseVisualStyleBackColor = true;
            this.randevuIslemleriBTN.Click += new System.EventHandler(this.randevuIslemleriBTN_Click);
            // 
            // receteIslemleriBTN
            // 
            this.receteIslemleriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.receteIslemleriBTN.Image = global::HRS_Desktop.Properties.Resources.ReceteIslemButtonPNG;
            this.receteIslemleriBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receteIslemleriBTN.Location = new System.Drawing.Point(12, 12);
            this.receteIslemleriBTN.Name = "receteIslemleriBTN";
            this.receteIslemleriBTN.Size = new System.Drawing.Size(1050, 205);
            this.receteIslemleriBTN.TabIndex = 1;
            this.receteIslemleriBTN.UseVisualStyleBackColor = true;
            this.receteIslemleriBTN.Click += new System.EventHandler(this.receteIslemleriBTN_Click);
            // 
            // kullaniciIslemleriBTN
            // 
            this.kullaniciIslemleriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.kullaniciIslemleriBTN.Image = global::HRS_Desktop.Properties.Resources.KullaniciIslemButtonPNG;
            this.kullaniciIslemleriBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullaniciIslemleriBTN.Location = new System.Drawing.Point(13, 223);
            this.kullaniciIslemleriBTN.Name = "kullaniciIslemleriBTN";
            this.kullaniciIslemleriBTN.Size = new System.Drawing.Size(1050, 205);
            this.kullaniciIslemleriBTN.TabIndex = 2;
            this.kullaniciIslemleriBTN.UseVisualStyleBackColor = true;
            this.kullaniciIslemleriBTN.Click += new System.EventHandler(this.kullaniciIslemleriBTN_Click);
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 720);
            this.Controls.Add(this.randevuIslemleriBTN);
            this.Controls.Add(this.receteIslemleriBTN);
            this.Controls.Add(this.cikisBTN);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.yardimBTN);
            this.Controls.Add(this.kullaniciIslemleriBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Seçim Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktorGiris_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullaniciIslemleriBTN;
        private System.Windows.Forms.Button cikisBTN;
        private System.Windows.Forms.Button geriBTN;
        private System.Windows.Forms.Button yardimBTN;
        private System.Windows.Forms.Button receteIslemleriBTN;
        private System.Windows.Forms.Button randevuIslemleriBTN;
    }
}