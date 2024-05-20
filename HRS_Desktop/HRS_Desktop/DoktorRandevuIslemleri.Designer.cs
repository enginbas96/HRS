namespace HRS_Desktop
{
    partial class DoktorRandevuIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorRandevuIslemleri));
            this.randevularimGB = new System.Windows.Forms.GroupBox();
            this.randevularimDGV = new System.Windows.Forms.DataGridView();
            this.hastaAdSoyadTXT = new System.Windows.Forms.TextBox();
            this.adSoyadLbl = new System.Windows.Forms.Label();
            this.randevuTarihiTXT = new System.Windows.Forms.TextBox();
            this.randevuSaatiText = new System.Windows.Forms.TextBox();
            this.hastaTcTXT = new System.Windows.Forms.TextBox();
            this.tarihLbl = new System.Windows.Forms.Label();
            this.saatLbl = new System.Windows.Forms.Label();
            this.hastaTcLbl = new System.Windows.Forms.Label();
            this.cikisBTN = new System.Windows.Forms.Button();
            this.geriBTN = new System.Windows.Forms.Button();
            this.randevularimGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevularimDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // randevularimGB
            // 
            this.randevularimGB.Controls.Add(this.randevularimDGV);
            this.randevularimGB.Controls.Add(this.hastaAdSoyadTXT);
            this.randevularimGB.Controls.Add(this.adSoyadLbl);
            this.randevularimGB.Controls.Add(this.randevuTarihiTXT);
            this.randevularimGB.Controls.Add(this.randevuSaatiText);
            this.randevularimGB.Controls.Add(this.hastaTcTXT);
            this.randevularimGB.Controls.Add(this.tarihLbl);
            this.randevularimGB.Controls.Add(this.saatLbl);
            this.randevularimGB.Controls.Add(this.hastaTcLbl);
            this.randevularimGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevularimGB.ForeColor = System.Drawing.Color.Maroon;
            this.randevularimGB.Location = new System.Drawing.Point(27, 21);
            this.randevularimGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevularimGB.Name = "randevularimGB";
            this.randevularimGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevularimGB.Size = new System.Drawing.Size(1080, 334);
            this.randevularimGB.TabIndex = 1;
            this.randevularimGB.TabStop = false;
            this.randevularimGB.Text = "Randevularım";
            // 
            // randevularimDGV
            // 
            this.randevularimDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevularimDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevularimDGV.Location = new System.Drawing.Point(5, 30);
            this.randevularimDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevularimDGV.Name = "randevularimDGV";
            this.randevularimDGV.ReadOnly = true;
            this.randevularimDGV.RowHeadersWidth = 51;
            this.randevularimDGV.RowTemplate.Height = 24;
            this.randevularimDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.randevularimDGV.Size = new System.Drawing.Size(776, 290);
            this.randevularimDGV.TabIndex = 31;
            this.randevularimDGV.TabStop = false;
            this.randevularimDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevularDGV_CellContentClick);
            // 
            // hastaAdSoyadTXT
            // 
            this.hastaAdSoyadTXT.Location = new System.Drawing.Point(793, 138);
            this.hastaAdSoyadTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaAdSoyadTXT.Name = "hastaAdSoyadTXT";
            this.hastaAdSoyadTXT.ReadOnly = true;
            this.hastaAdSoyadTXT.Size = new System.Drawing.Size(272, 30);
            this.hastaAdSoyadTXT.TabIndex = 9;
            this.hastaAdSoyadTXT.TabStop = false;
            // 
            // adSoyadLbl
            // 
            this.adSoyadLbl.AutoSize = true;
            this.adSoyadLbl.Location = new System.Drawing.Point(788, 105);
            this.adSoyadLbl.Name = "adSoyadLbl";
            this.adSoyadLbl.Size = new System.Drawing.Size(169, 25);
            this.adSoyadLbl.TabIndex = 8;
            this.adSoyadLbl.Text = "Hasta Ad Soyad";
            // 
            // randevuTarihiTXT
            // 
            this.randevuTarihiTXT.Location = new System.Drawing.Point(793, 214);
            this.randevuTarihiTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuTarihiTXT.Name = "randevuTarihiTXT";
            this.randevuTarihiTXT.ReadOnly = true;
            this.randevuTarihiTXT.Size = new System.Drawing.Size(272, 30);
            this.randevuTarihiTXT.TabIndex = 7;
            this.randevuTarihiTXT.TabStop = false;
            // 
            // randevuSaatiText
            // 
            this.randevuSaatiText.Location = new System.Drawing.Point(793, 290);
            this.randevuSaatiText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuSaatiText.Name = "randevuSaatiText";
            this.randevuSaatiText.ReadOnly = true;
            this.randevuSaatiText.Size = new System.Drawing.Size(272, 30);
            this.randevuSaatiText.TabIndex = 6;
            this.randevuSaatiText.TabStop = false;
            // 
            // hastaTcTXT
            // 
            this.hastaTcTXT.Location = new System.Drawing.Point(793, 62);
            this.hastaTcTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaTcTXT.Name = "hastaTcTXT";
            this.hastaTcTXT.ReadOnly = true;
            this.hastaTcTXT.Size = new System.Drawing.Size(272, 30);
            this.hastaTcTXT.TabIndex = 5;
            this.hastaTcTXT.TabStop = false;
            // 
            // tarihLbl
            // 
            this.tarihLbl.AutoSize = true;
            this.tarihLbl.Location = new System.Drawing.Point(788, 181);
            this.tarihLbl.Name = "tarihLbl";
            this.tarihLbl.Size = new System.Drawing.Size(214, 25);
            this.tarihLbl.TabIndex = 4;
            this.tarihLbl.Text = "Randevu Tarihi Tarih";
            // 
            // saatLbl
            // 
            this.saatLbl.AutoSize = true;
            this.saatLbl.Location = new System.Drawing.Point(788, 257);
            this.saatLbl.Name = "saatLbl";
            this.saatLbl.Size = new System.Drawing.Size(153, 25);
            this.saatLbl.TabIndex = 3;
            this.saatLbl.Text = "Randevu Saati";
            // 
            // hastaTcLbl
            // 
            this.hastaTcLbl.AutoSize = true;
            this.hastaTcLbl.Location = new System.Drawing.Point(788, 30);
            this.hastaTcLbl.Name = "hastaTcLbl";
            this.hastaTcLbl.Size = new System.Drawing.Size(104, 25);
            this.hastaTcLbl.TabIndex = 2;
            this.hastaTcLbl.Text = "Hasta TC";
            // 
            // cikisBTN
            // 
            this.cikisBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBTN.Location = new System.Drawing.Point(965, 378);
            this.cikisBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisBTN.Name = "cikisBTN";
            this.cikisBTN.Size = new System.Drawing.Size(141, 63);
            this.cikisBTN.TabIndex = 2;
            this.cikisBTN.Text = "Çıkış";
            this.cikisBTN.UseVisualStyleBackColor = true;
            this.cikisBTN.Click += new System.EventHandler(this.cikisBTN_Click);
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBTN.Location = new System.Drawing.Point(817, 378);
            this.geriBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(141, 63);
            this.geriBTN.TabIndex = 3;
            this.geriBTN.Text = "Geri";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // DoktorRandevuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 453);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.cikisBTN);
            this.Controls.Add(this.randevularimGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoktorRandevuIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Görüntüleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktorRandevuIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.DoktorRandevuIslemleri_Load);
            this.randevularimGB.ResumeLayout(false);
            this.randevularimGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevularimDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox randevularimGB;
        private System.Windows.Forms.TextBox randevuTarihiTXT;
        private System.Windows.Forms.TextBox randevuSaatiText;
        private System.Windows.Forms.TextBox hastaTcTXT;
        private System.Windows.Forms.Label tarihLbl;
        private System.Windows.Forms.Label saatLbl;
        private System.Windows.Forms.Label hastaTcLbl;
        private System.Windows.Forms.TextBox hastaAdSoyadTXT;
        private System.Windows.Forms.Label adSoyadLbl;
        private System.Windows.Forms.Button cikisBTN;
        private System.Windows.Forms.Button geriBTN;
        private System.Windows.Forms.DataGridView randevularimDGV;
    }
}