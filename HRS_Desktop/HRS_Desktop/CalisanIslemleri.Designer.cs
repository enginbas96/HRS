namespace HRS_Desktop
{
    partial class CalisanIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanIslemleri));
            this.sifreDegistirBTN = new System.Windows.Forms.Button();
            this.eskiSifreLBL = new System.Windows.Forms.Label();
            this.sifreLBL = new System.Windows.Forms.Label();
            this.sifreTekrarLBL = new System.Windows.Forms.Label();
            this.sifreIslemleriGB = new System.Windows.Forms.GroupBox();
            this.sifreTekrarTXT = new System.Windows.Forms.TextBox();
            this.SifreTXT = new System.Windows.Forms.TextBox();
            this.eskiSifreTXT = new System.Windows.Forms.TextBox();
            this.bilgilerimGB = new System.Windows.Forms.GroupBox();
            this.birimTXT = new System.Windows.Forms.TextBox();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.adSoyadTXT = new System.Windows.Forms.TextBox();
            this.tcTXT = new System.Windows.Forms.TextBox();
            this.birimLBL = new System.Windows.Forms.Label();
            this.emailLBL = new System.Windows.Forms.Label();
            this.adSoyadLBL = new System.Windows.Forms.Label();
            this.tcNoLBL = new System.Windows.Forms.Label();
            this.sorunTXT = new System.Windows.Forms.RichTextBox();
            this.sorunBildirGB = new System.Windows.Forms.GroupBox();
            this.sikayetSorunLBL = new System.Windows.Forms.Label();
            this.gonderBTN = new System.Windows.Forms.Button();
            this.yardimBTN = new System.Windows.Forms.Button();
            this.cikisBTN = new System.Windows.Forms.Button();
            this.geriBTN = new System.Windows.Forms.Button();
            this.sifreIslemleriGB.SuspendLayout();
            this.bilgilerimGB.SuspendLayout();
            this.sorunBildirGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // sifreDegistirBTN
            // 
            this.sifreDegistirBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sifreDegistirBTN.Location = new System.Drawing.Point(27, 288);
            this.sifreDegistirBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreDegistirBTN.Name = "sifreDegistirBTN";
            this.sifreDegistirBTN.Size = new System.Drawing.Size(223, 53);
            this.sifreDegistirBTN.TabIndex = 5;
            this.sifreDegistirBTN.Text = "Şifre Değiştir";
            this.sifreDegistirBTN.UseVisualStyleBackColor = true;
            this.sifreDegistirBTN.Click += new System.EventHandler(this.sifreDegistirBTN_Click);
            // 
            // eskiSifreLBL
            // 
            this.eskiSifreLBL.AutoSize = true;
            this.eskiSifreLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eskiSifreLBL.Location = new System.Drawing.Point(28, 50);
            this.eskiSifreLBL.Name = "eskiSifreLBL";
            this.eskiSifreLBL.Size = new System.Drawing.Size(132, 25);
            this.eskiSifreLBL.TabIndex = 1;
            this.eskiSifreLBL.Text = "Eski Şifreniz";
            // 
            // sifreLBL
            // 
            this.sifreLBL.AutoSize = true;
            this.sifreLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sifreLBL.Location = new System.Drawing.Point(28, 126);
            this.sifreLBL.Name = "sifreLBL";
            this.sifreLBL.Size = new System.Drawing.Size(134, 25);
            this.sifreLBL.TabIndex = 2;
            this.sifreLBL.Text = "Yeni Şifreniz";
            // 
            // sifreTekrarLBL
            // 
            this.sifreTekrarLBL.AutoSize = true;
            this.sifreTekrarLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sifreTekrarLBL.Location = new System.Drawing.Point(21, 202);
            this.sifreTekrarLBL.Name = "sifreTekrarLBL";
            this.sifreTekrarLBL.Size = new System.Drawing.Size(219, 25);
            this.sifreTekrarLBL.TabIndex = 3;
            this.sifreTekrarLBL.Text = "Yeni Şifreniz (Tekrar)";
            // 
            // sifreIslemleriGB
            // 
            this.sifreIslemleriGB.Controls.Add(this.sifreTekrarTXT);
            this.sifreIslemleriGB.Controls.Add(this.SifreTXT);
            this.sifreIslemleriGB.Controls.Add(this.eskiSifreTXT);
            this.sifreIslemleriGB.Controls.Add(this.sifreTekrarLBL);
            this.sifreIslemleriGB.Controls.Add(this.sifreLBL);
            this.sifreIslemleriGB.Controls.Add(this.eskiSifreLBL);
            this.sifreIslemleriGB.Controls.Add(this.sifreDegistirBTN);
            this.sifreIslemleriGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreIslemleriGB.ForeColor = System.Drawing.Color.Maroon;
            this.sifreIslemleriGB.Location = new System.Drawing.Point(27, 22);
            this.sifreIslemleriGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreIslemleriGB.Name = "sifreIslemleriGB";
            this.sifreIslemleriGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreIslemleriGB.Size = new System.Drawing.Size(277, 375);
            this.sifreIslemleriGB.TabIndex = 1;
            this.sifreIslemleriGB.TabStop = false;
            this.sifreIslemleriGB.Text = "Şifre İşlemleri";
            // 
            // sifreTekrarTXT
            // 
            this.sifreTekrarTXT.Location = new System.Drawing.Point(27, 235);
            this.sifreTekrarTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreTekrarTXT.Name = "sifreTekrarTXT";
            this.sifreTekrarTXT.PasswordChar = '*';
            this.sifreTekrarTXT.Size = new System.Drawing.Size(223, 30);
            this.sifreTekrarTXT.TabIndex = 4;
            // 
            // SifreTXT
            // 
            this.SifreTXT.Location = new System.Drawing.Point(27, 159);
            this.SifreTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SifreTXT.Name = "SifreTXT";
            this.SifreTXT.PasswordChar = '*';
            this.SifreTXT.Size = new System.Drawing.Size(223, 30);
            this.SifreTXT.TabIndex = 3;
            // 
            // eskiSifreTXT
            // 
            this.eskiSifreTXT.Location = new System.Drawing.Point(27, 82);
            this.eskiSifreTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eskiSifreTXT.Name = "eskiSifreTXT";
            this.eskiSifreTXT.Size = new System.Drawing.Size(223, 30);
            this.eskiSifreTXT.TabIndex = 2;
            // 
            // bilgilerimGB
            // 
            this.bilgilerimGB.Controls.Add(this.birimTXT);
            this.bilgilerimGB.Controls.Add(this.emailTXT);
            this.bilgilerimGB.Controls.Add(this.adSoyadTXT);
            this.bilgilerimGB.Controls.Add(this.tcTXT);
            this.bilgilerimGB.Controls.Add(this.birimLBL);
            this.bilgilerimGB.Controls.Add(this.emailLBL);
            this.bilgilerimGB.Controls.Add(this.adSoyadLBL);
            this.bilgilerimGB.Controls.Add(this.tcNoLBL);
            this.bilgilerimGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilerimGB.ForeColor = System.Drawing.Color.Maroon;
            this.bilgilerimGB.Location = new System.Drawing.Point(309, 22);
            this.bilgilerimGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgilerimGB.Name = "bilgilerimGB";
            this.bilgilerimGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgilerimGB.Size = new System.Drawing.Size(269, 375);
            this.bilgilerimGB.TabIndex = 545;
            this.bilgilerimGB.TabStop = false;
            this.bilgilerimGB.Text = "Bilgilerim";
            // 
            // birimTXT
            // 
            this.birimTXT.Location = new System.Drawing.Point(37, 311);
            this.birimTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birimTXT.Name = "birimTXT";
            this.birimTXT.ReadOnly = true;
            this.birimTXT.Size = new System.Drawing.Size(189, 30);
            this.birimTXT.TabIndex = 7;
            this.birimTXT.TabStop = false;
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(37, 235);
            this.emailTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.ReadOnly = true;
            this.emailTXT.Size = new System.Drawing.Size(189, 30);
            this.emailTXT.TabIndex = 6;
            this.emailTXT.TabStop = false;
            // 
            // adSoyadTXT
            // 
            this.adSoyadTXT.Location = new System.Drawing.Point(37, 159);
            this.adSoyadTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adSoyadTXT.Name = "adSoyadTXT";
            this.adSoyadTXT.ReadOnly = true;
            this.adSoyadTXT.Size = new System.Drawing.Size(189, 30);
            this.adSoyadTXT.TabIndex = 5;
            this.adSoyadTXT.TabStop = false;
            // 
            // tcTXT
            // 
            this.tcTXT.Location = new System.Drawing.Point(37, 82);
            this.tcTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcTXT.Name = "tcTXT";
            this.tcTXT.ReadOnly = true;
            this.tcTXT.Size = new System.Drawing.Size(189, 30);
            this.tcTXT.TabIndex = 4;
            this.tcTXT.TabStop = false;
            // 
            // birimLBL
            // 
            this.birimLBL.AutoSize = true;
            this.birimLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.birimLBL.Location = new System.Drawing.Point(32, 278);
            this.birimLBL.Name = "birimLBL";
            this.birimLBL.Size = new System.Drawing.Size(60, 25);
            this.birimLBL.TabIndex = 3;
            this.birimLBL.Text = "Birim";
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailLBL.Location = new System.Drawing.Point(32, 202);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(120, 25);
            this.emailLBL.TabIndex = 2;
            this.emailLBL.Text = "Mail Adresi";
            // 
            // adSoyadLBL
            // 
            this.adSoyadLBL.AutoSize = true;
            this.adSoyadLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adSoyadLBL.Location = new System.Drawing.Point(32, 126);
            this.adSoyadLBL.Name = "adSoyadLBL";
            this.adSoyadLBL.Size = new System.Drawing.Size(107, 25);
            this.adSoyadLBL.TabIndex = 1;
            this.adSoyadLBL.Text = "Ad Soyad";
            // 
            // tcNoLBL
            // 
            this.tcNoLBL.AutoSize = true;
            this.tcNoLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tcNoLBL.Location = new System.Drawing.Point(32, 50);
            this.tcNoLBL.Name = "tcNoLBL";
            this.tcNoLBL.Size = new System.Drawing.Size(139, 25);
            this.tcNoLBL.TabIndex = 0;
            this.tcNoLBL.Text = "TC Kimlik No";
            // 
            // sorunTXT
            // 
            this.sorunTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunTXT.Location = new System.Drawing.Point(5, 82);
            this.sorunTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sorunTXT.Name = "sorunTXT";
            this.sorunTXT.Size = new System.Drawing.Size(325, 134);
            this.sorunTXT.TabIndex = 7;
            this.sorunTXT.Text = "";
            // 
            // sorunBildirGB
            // 
            this.sorunBildirGB.BackColor = System.Drawing.SystemColors.Control;
            this.sorunBildirGB.Controls.Add(this.sikayetSorunLBL);
            this.sorunBildirGB.Controls.Add(this.gonderBTN);
            this.sorunBildirGB.Controls.Add(this.sorunTXT);
            this.sorunBildirGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunBildirGB.ForeColor = System.Drawing.Color.Maroon;
            this.sorunBildirGB.Location = new System.Drawing.Point(584, 22);
            this.sorunBildirGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sorunBildirGB.Name = "sorunBildirGB";
            this.sorunBildirGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sorunBildirGB.Size = new System.Drawing.Size(337, 313);
            this.sorunBildirGB.TabIndex = 6;
            this.sorunBildirGB.TabStop = false;
            this.sorunBildirGB.Text = "Sorun Bildir";
            // 
            // sikayetSorunLBL
            // 
            this.sikayetSorunLBL.AutoSize = true;
            this.sikayetSorunLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sikayetSorunLBL.Location = new System.Drawing.Point(56, 50);
            this.sikayetSorunLBL.Name = "sikayetSorunLBL";
            this.sikayetSorunLBL.Size = new System.Drawing.Size(223, 25);
            this.sikayetSorunLBL.TabIndex = 49;
            this.sikayetSorunLBL.Text = "Şikayet/Sorun Kutusu";
            // 
            // gonderBTN
            // 
            this.gonderBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gonderBTN.Location = new System.Drawing.Point(195, 234);
            this.gonderBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gonderBTN.Name = "gonderBTN";
            this.gonderBTN.Size = new System.Drawing.Size(132, 64);
            this.gonderBTN.TabIndex = 8;
            this.gonderBTN.Text = "Gönder";
            this.gonderBTN.UseVisualStyleBackColor = true;
            this.gonderBTN.Click += new System.EventHandler(this.gonderBTN_Click);
            // 
            // yardimBTN
            // 
            this.yardimBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yardimBTN.Location = new System.Drawing.Point(584, 350);
            this.yardimBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yardimBTN.Name = "yardimBTN";
            this.yardimBTN.Size = new System.Drawing.Size(108, 47);
            this.yardimBTN.TabIndex = 9;
            this.yardimBTN.Text = "Yardım";
            this.yardimBTN.UseVisualStyleBackColor = true;
            this.yardimBTN.Click += new System.EventHandler(this.yardimBTN_Click);
            // 
            // cikisBTN
            // 
            this.cikisBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cikisBTN.Location = new System.Drawing.Point(813, 350);
            this.cikisBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisBTN.Name = "cikisBTN";
            this.cikisBTN.Size = new System.Drawing.Size(108, 47);
            this.cikisBTN.TabIndex = 11;
            this.cikisBTN.Text = "Çıkış";
            this.cikisBTN.UseVisualStyleBackColor = true;
            this.cikisBTN.Click += new System.EventHandler(this.cikisBTN_Click);
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.geriBTN.Location = new System.Drawing.Point(699, 350);
            this.geriBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(109, 47);
            this.geriBTN.TabIndex = 10;
            this.geriBTN.Text = "Geri";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // CalisanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 420);
            this.Controls.Add(this.yardimBTN);
            this.Controls.Add(this.cikisBTN);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.sorunBildirGB);
            this.Controls.Add(this.bilgilerimGB);
            this.Controls.Add(this.sifreIslemleriGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalisanIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Ayarları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalisanIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.CalisanIslemleri_Load);
            this.sifreIslemleriGB.ResumeLayout(false);
            this.sifreIslemleriGB.PerformLayout();
            this.bilgilerimGB.ResumeLayout(false);
            this.bilgilerimGB.PerformLayout();
            this.sorunBildirGB.ResumeLayout(false);
            this.sorunBildirGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sifreDegistirBTN;
        private System.Windows.Forms.Label eskiSifreLBL;
        private System.Windows.Forms.Label sifreLBL;
        private System.Windows.Forms.Label sifreTekrarLBL;
        private System.Windows.Forms.GroupBox sifreIslemleriGB;
        private System.Windows.Forms.TextBox sifreTekrarTXT;
        private System.Windows.Forms.TextBox SifreTXT;
        private System.Windows.Forms.TextBox eskiSifreTXT;
        private System.Windows.Forms.GroupBox bilgilerimGB;
        private System.Windows.Forms.TextBox birimTXT;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.TextBox adSoyadTXT;
        private System.Windows.Forms.TextBox tcTXT;
        private System.Windows.Forms.Label birimLBL;
        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.Label adSoyadLBL;
        private System.Windows.Forms.Label tcNoLBL;
        private System.Windows.Forms.RichTextBox sorunTXT;
        private System.Windows.Forms.GroupBox sorunBildirGB;
        private System.Windows.Forms.Button gonderBTN;
        private System.Windows.Forms.Label sikayetSorunLBL;
        private System.Windows.Forms.Button yardimBTN;
        private System.Windows.Forms.Button cikisBTN;
        private System.Windows.Forms.Button geriBTN;
    }
}