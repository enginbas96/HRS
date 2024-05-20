namespace HRS_Desktop
{
    partial class HastaKayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayitForm));
            this.hastayiKaydetBTN = new System.Windows.Forms.Button();
            this.hastaTcNoLBL = new System.Windows.Forms.Label();
            this.hastaAdLBL = new System.Windows.Forms.Label();
            this.hastaSoyadLBL = new System.Windows.Forms.Label();
            this.hastaMailLBL = new System.Windows.Forms.Label();
            this.hastaDogumYiliLBL = new System.Windows.Forms.Label();
            this.hastaCinsiyetLBL = new System.Windows.Forms.Label();
            this.hastaTcNoTXT = new System.Windows.Forms.TextBox();
            this.hastaAdTXT = new System.Windows.Forms.TextBox();
            this.hastaSoyadTXT = new System.Windows.Forms.TextBox();
            this.hastaMailTXT = new System.Windows.Forms.TextBox();
            this.hastaDogumYiliTXT = new System.Windows.Forms.TextBox();
            this.erkekRBTN = new System.Windows.Forms.RadioButton();
            this.kadinRBN = new System.Windows.Forms.RadioButton();
            this.geriBTN = new System.Windows.Forms.Button();
            this.hastaKayitPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitPB)).BeginInit();
            this.SuspendLayout();
            // 
            // hastayiKaydetBTN
            // 
            this.hastayiKaydetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastayiKaydetBTN.Location = new System.Drawing.Point(657, 320);
            this.hastayiKaydetBTN.Name = "hastayiKaydetBTN";
            this.hastayiKaydetBTN.Size = new System.Drawing.Size(191, 47);
            this.hastayiKaydetBTN.TabIndex = 8;
            this.hastayiKaydetBTN.Text = "Hastayı Kaydet";
            this.hastayiKaydetBTN.UseVisualStyleBackColor = true;
            this.hastayiKaydetBTN.Click += new System.EventHandler(this.hastayiKaydetBTN_Click);
            // 
            // hastaTcNoLBL
            // 
            this.hastaTcNoLBL.AutoSize = true;
            this.hastaTcNoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaTcNoLBL.Location = new System.Drawing.Point(450, 25);
            this.hastaTcNoLBL.Name = "hastaTcNoLBL";
            this.hastaTcNoLBL.Size = new System.Drawing.Size(170, 25);
            this.hastaTcNoLBL.TabIndex = 111;
            this.hastaTcNoLBL.Text = "T.C. Kimlik No : ";
            // 
            // hastaAdLBL
            // 
            this.hastaAdLBL.AutoSize = true;
            this.hastaAdLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaAdLBL.Location = new System.Drawing.Point(557, 71);
            this.hastaAdLBL.Name = "hastaAdLBL";
            this.hastaAdLBL.Size = new System.Drawing.Size(63, 25);
            this.hastaAdLBL.TabIndex = 211;
            this.hastaAdLBL.Text = "Adı : ";
            // 
            // hastaSoyadLBL
            // 
            this.hastaSoyadLBL.AutoSize = true;
            this.hastaSoyadLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaSoyadLBL.Location = new System.Drawing.Point(522, 116);
            this.hastaSoyadLBL.Name = "hastaSoyadLBL";
            this.hastaSoyadLBL.Size = new System.Drawing.Size(98, 25);
            this.hastaSoyadLBL.TabIndex = 311;
            this.hastaSoyadLBL.Text = "Soyadı : ";
            // 
            // hastaMailLBL
            // 
            this.hastaMailLBL.AutoSize = true;
            this.hastaMailLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaMailLBL.Location = new System.Drawing.Point(444, 161);
            this.hastaMailLBL.Name = "hastaMailLBL";
            this.hastaMailLBL.Size = new System.Drawing.Size(176, 25);
            this.hastaMailLBL.TabIndex = 411;
            this.hastaMailLBL.Text = "E-Posta Adresi : ";
            // 
            // hastaDogumYiliLBL
            // 
            this.hastaDogumYiliLBL.AutoSize = true;
            this.hastaDogumYiliLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaDogumYiliLBL.Location = new System.Drawing.Point(486, 207);
            this.hastaDogumYiliLBL.Name = "hastaDogumYiliLBL";
            this.hastaDogumYiliLBL.Size = new System.Drawing.Size(134, 25);
            this.hastaDogumYiliLBL.TabIndex = 511;
            this.hastaDogumYiliLBL.Text = "Doğum Yılı : ";
            // 
            // hastaCinsiyetLBL
            // 
            this.hastaCinsiyetLBL.AutoSize = true;
            this.hastaCinsiyetLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaCinsiyetLBL.Location = new System.Drawing.Point(506, 257);
            this.hastaCinsiyetLBL.Name = "hastaCinsiyetLBL";
            this.hastaCinsiyetLBL.Size = new System.Drawing.Size(114, 25);
            this.hastaCinsiyetLBL.TabIndex = 611;
            this.hastaCinsiyetLBL.Text = "Cinsiyeti : ";
            // 
            // hastaTcNoTXT
            // 
            this.hastaTcNoTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaTcNoTXT.Location = new System.Drawing.Point(626, 22);
            this.hastaTcNoTXT.MaxLength = 11;
            this.hastaTcNoTXT.Name = "hastaTcNoTXT";
            this.hastaTcNoTXT.Size = new System.Drawing.Size(222, 30);
            this.hastaTcNoTXT.TabIndex = 1;
            this.hastaTcNoTXT.TextChanged += new System.EventHandler(this.hastaTcNoTXT_TextChanged);
            // 
            // hastaAdTXT
            // 
            this.hastaAdTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaAdTXT.Location = new System.Drawing.Point(626, 68);
            this.hastaAdTXT.MaxLength = 32;
            this.hastaAdTXT.Name = "hastaAdTXT";
            this.hastaAdTXT.Size = new System.Drawing.Size(222, 30);
            this.hastaAdTXT.TabIndex = 2;
            this.hastaAdTXT.TextChanged += new System.EventHandler(this.hastaAdTXT_TextChanged);
            // 
            // hastaSoyadTXT
            // 
            this.hastaSoyadTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaSoyadTXT.Location = new System.Drawing.Point(626, 113);
            this.hastaSoyadTXT.MaxLength = 32;
            this.hastaSoyadTXT.Name = "hastaSoyadTXT";
            this.hastaSoyadTXT.Size = new System.Drawing.Size(222, 30);
            this.hastaSoyadTXT.TabIndex = 3;
            this.hastaSoyadTXT.TextChanged += new System.EventHandler(this.hastaSoyadTXT_TextChanged);
            // 
            // hastaMailTXT
            // 
            this.hastaMailTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaMailTXT.Location = new System.Drawing.Point(626, 158);
            this.hastaMailTXT.MaxLength = 128;
            this.hastaMailTXT.Name = "hastaMailTXT";
            this.hastaMailTXT.Size = new System.Drawing.Size(222, 30);
            this.hastaMailTXT.TabIndex = 4;
            // 
            // hastaDogumYiliTXT
            // 
            this.hastaDogumYiliTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaDogumYiliTXT.Location = new System.Drawing.Point(626, 204);
            this.hastaDogumYiliTXT.MaxLength = 4;
            this.hastaDogumYiliTXT.Name = "hastaDogumYiliTXT";
            this.hastaDogumYiliTXT.Size = new System.Drawing.Size(222, 30);
            this.hastaDogumYiliTXT.TabIndex = 5;
            this.hastaDogumYiliTXT.TextChanged += new System.EventHandler(this.hastaDogumYiliTXT_TextChanged);
            // 
            // erkekRBTN
            // 
            this.erkekRBTN.AutoSize = true;
            this.erkekRBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkekRBTN.Location = new System.Drawing.Point(631, 255);
            this.erkekRBTN.Name = "erkekRBTN";
            this.erkekRBTN.Size = new System.Drawing.Size(88, 29);
            this.erkekRBTN.TabIndex = 6;
            this.erkekRBTN.TabStop = true;
            this.erkekRBTN.Text = "Erkek";
            this.erkekRBTN.UseVisualStyleBackColor = true;
            // 
            // kadinRBN
            // 
            this.kadinRBN.AutoSize = true;
            this.kadinRBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadinRBN.Location = new System.Drawing.Point(759, 255);
            this.kadinRBN.Name = "kadinRBN";
            this.kadinRBN.Size = new System.Drawing.Size(89, 29);
            this.kadinRBN.TabIndex = 7;
            this.kadinRBN.TabStop = true;
            this.kadinRBN.Text = "Kadın";
            this.kadinRBN.UseVisualStyleBackColor = true;
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBTN.Location = new System.Drawing.Point(491, 320);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(129, 47);
            this.geriBTN.TabIndex = 9;
            this.geriBTN.Text = "Geri";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // hastaKayitPB
            // 
            this.hastaKayitPB.Image = global::HRS_Desktop.Properties.Resources.Hasta_Kayit_Form;
            this.hastaKayitPB.Location = new System.Drawing.Point(12, 12);
            this.hastaKayitPB.Name = "hastaKayitPB";
            this.hastaKayitPB.Size = new System.Drawing.Size(406, 359);
            this.hastaKayitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hastaKayitPB.TabIndex = 612;
            this.hastaKayitPB.TabStop = false;
            // 
            // HastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 383);
            this.Controls.Add(this.hastaKayitPB);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.kadinRBN);
            this.Controls.Add(this.erkekRBTN);
            this.Controls.Add(this.hastaDogumYiliTXT);
            this.Controls.Add(this.hastaMailTXT);
            this.Controls.Add(this.hastaSoyadTXT);
            this.Controls.Add(this.hastaAdTXT);
            this.Controls.Add(this.hastaTcNoTXT);
            this.Controls.Add(this.hastaCinsiyetLBL);
            this.Controls.Add(this.hastaDogumYiliLBL);
            this.Controls.Add(this.hastaMailLBL);
            this.Controls.Add(this.hastaSoyadLBL);
            this.Controls.Add(this.hastaAdLBL);
            this.Controls.Add(this.hastaTcNoLBL);
            this.Controls.Add(this.hastayiKaydetBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HastaKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HastaKayitForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastayiKaydetBTN;
        private System.Windows.Forms.Label hastaTcNoLBL;
        private System.Windows.Forms.Label hastaAdLBL;
        private System.Windows.Forms.Label hastaSoyadLBL;
        private System.Windows.Forms.Label hastaMailLBL;
        private System.Windows.Forms.Label hastaDogumYiliLBL;
        private System.Windows.Forms.Label hastaCinsiyetLBL;
        private System.Windows.Forms.TextBox hastaTcNoTXT;
        private System.Windows.Forms.TextBox hastaAdTXT;
        private System.Windows.Forms.TextBox hastaSoyadTXT;
        private System.Windows.Forms.TextBox hastaMailTXT;
        private System.Windows.Forms.TextBox hastaDogumYiliTXT;
        private System.Windows.Forms.RadioButton erkekRBTN;
        private System.Windows.Forms.RadioButton kadinRBN;
        private System.Windows.Forms.Button geriBTN;
        private System.Windows.Forms.PictureBox hastaKayitPB;
    }
}