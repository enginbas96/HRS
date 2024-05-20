namespace HRS_Desktop
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.girisYapBTN = new System.Windows.Forms.Button();
            this.kullaniciAdiLBL = new System.Windows.Forms.Label();
            this.sifreLBL = new System.Windows.Forms.Label();
            this.kAdiTXT = new System.Windows.Forms.TextBox();
            this.sifreTXT = new System.Windows.Forms.TextBox();
            this.girisPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.girisPB)).BeginInit();
            this.SuspendLayout();
            // 
            // girisYapBTN
            // 
            this.girisYapBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapBTN.Location = new System.Drawing.Point(12, 342);
            this.girisYapBTN.Name = "girisYapBTN";
            this.girisYapBTN.Size = new System.Drawing.Size(217, 57);
            this.girisYapBTN.TabIndex = 3;
            this.girisYapBTN.Text = "Giriş Yap";
            this.girisYapBTN.UseVisualStyleBackColor = true;
            this.girisYapBTN.Click += new System.EventHandler(this.girisYapBTN_Click);
            // 
            // kullaniciAdiLBL
            // 
            this.kullaniciAdiLBL.AutoSize = true;
            this.kullaniciAdiLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiLBL.Location = new System.Drawing.Point(37, 197);
            this.kullaniciAdiLBL.Name = "kullaniciAdiLBL";
            this.kullaniciAdiLBL.Size = new System.Drawing.Size(160, 25);
            this.kullaniciAdiLBL.TabIndex = 44;
            this.kullaniciAdiLBL.Text = "Kullanıcı Adınız";
            // 
            // sifreLBL
            // 
            this.sifreLBL.AutoSize = true;
            this.sifreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLBL.Location = new System.Drawing.Point(73, 268);
            this.sifreLBL.Name = "sifreLBL";
            this.sifreLBL.Size = new System.Drawing.Size(85, 25);
            this.sifreLBL.TabIndex = 55;
            this.sifreLBL.Text = "Şifreniz";
            // 
            // kAdiTXT
            // 
            this.kAdiTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdiTXT.Location = new System.Drawing.Point(12, 225);
            this.kAdiTXT.MaxLength = 11;
            this.kAdiTXT.Name = "kAdiTXT";
            this.kAdiTXT.Size = new System.Drawing.Size(217, 30);
            this.kAdiTXT.TabIndex = 1;
            this.kAdiTXT.TextChanged += new System.EventHandler(this.kAdiText_TextChanged);
            // 
            // sifreTXT
            // 
            this.sifreTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTXT.Location = new System.Drawing.Point(12, 296);
            this.sifreTXT.MaxLength = 16;
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.PasswordChar = '*';
            this.sifreTXT.Size = new System.Drawing.Size(217, 30);
            this.sifreTXT.TabIndex = 2;
            // 
            // girisPB
            // 
            this.girisPB.Image = global::HRS_Desktop.Properties.Resources._1;
            this.girisPB.Location = new System.Drawing.Point(12, 12);
            this.girisPB.Name = "girisPB";
            this.girisPB.Size = new System.Drawing.Size(217, 172);
            this.girisPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girisPB.TabIndex = 5;
            this.girisPB.TabStop = false;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 410);
            this.Controls.Add(this.girisPB);
            this.Controls.Add(this.sifreTXT);
            this.Controls.Add(this.kAdiTXT);
            this.Controls.Add(this.sifreLBL);
            this.Controls.Add(this.kullaniciAdiLBL);
            this.Controls.Add(this.girisYapBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.girisPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisYapBTN;
        private System.Windows.Forms.Label kullaniciAdiLBL;
        private System.Windows.Forms.Label sifreLBL;
        private System.Windows.Forms.TextBox kAdiTXT;
        private System.Windows.Forms.TextBox sifreTXT;
        private System.Windows.Forms.PictureBox girisPB;
    }
}

