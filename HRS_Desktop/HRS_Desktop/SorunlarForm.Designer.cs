namespace HRS_Desktop
{
    partial class SorunlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorunlarForm));
            this.sorunlarDGV = new System.Windows.Forms.DataGridView();
            this.sorunDurumCB = new System.Windows.Forms.ComboBox();
            this.sorunDurumLBL = new System.Windows.Forms.Label();
            this.geriBTN = new System.Windows.Forms.Button();
            this.sorunBildirenTcLBL = new System.Windows.Forms.Label();
            this.sorunAciklamaLBL = new System.Windows.Forms.Label();
            this.sorunDurum2LBL = new System.Windows.Forms.Label();
            this.cozumRaporLBL = new System.Windows.Forms.Label();
            this.sorunBildirenTcTXT = new System.Windows.Forms.TextBox();
            this.sorunAciklamaTXT = new System.Windows.Forms.RichTextBox();
            this.sorunDurum2CB = new System.Windows.Forms.ComboBox();
            this.cozumRaporTXT = new System.Windows.Forms.RichTextBox();
            this.guncelleBTN = new System.Windows.Forms.Button();
            this.hastaneLBL = new System.Windows.Forms.Label();
            this.hastaneTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sorunlarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sorunlarDGV
            // 
            this.sorunlarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sorunlarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sorunlarDGV.Location = new System.Drawing.Point(17, 77);
            this.sorunlarDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sorunlarDGV.Name = "sorunlarDGV";
            this.sorunlarDGV.ReadOnly = true;
            this.sorunlarDGV.RowHeadersWidth = 51;
            this.sorunlarDGV.RowTemplate.Height = 24;
            this.sorunlarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sorunlarDGV.Size = new System.Drawing.Size(1023, 302);
            this.sorunlarDGV.TabIndex = 32;
            this.sorunlarDGV.TabStop = false;
            this.sorunlarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sorunlarDGV_CellContentClick);
            // 
            // sorunDurumCB
            // 
            this.sorunDurumCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sorunDurumCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunDurumCB.FormattingEnabled = true;
            this.sorunDurumCB.Items.AddRange(new object[] {
            "Beklemede",
            "Çözüldü",
            "Çözülemedi"});
            this.sorunDurumCB.Location = new System.Drawing.Point(261, 22);
            this.sorunDurumCB.Name = "sorunDurumCB";
            this.sorunDurumCB.Size = new System.Drawing.Size(269, 39);
            this.sorunDurumCB.TabIndex = 33;
            this.sorunDurumCB.SelectedIndexChanged += new System.EventHandler(this.sorunDurumCB_SelectedIndexChanged);
            // 
            // sorunDurumLBL
            // 
            this.sorunDurumLBL.AutoSize = true;
            this.sorunDurumLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunDurumLBL.Location = new System.Drawing.Point(12, 28);
            this.sorunDurumLBL.Name = "sorunDurumLBL";
            this.sorunDurumLBL.Size = new System.Drawing.Size(221, 29);
            this.sorunDurumLBL.TabIndex = 34;
            this.sorunDurumLBL.Text = "Sorunun Durumu :";
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBTN.Location = new System.Drawing.Point(868, 12);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(172, 49);
            this.geriBTN.TabIndex = 35;
            this.geriBTN.Text = "Geri";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // sorunBildirenTcLBL
            // 
            this.sorunBildirenTcLBL.AutoSize = true;
            this.sorunBildirenTcLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunBildirenTcLBL.Location = new System.Drawing.Point(15, 416);
            this.sorunBildirenTcLBL.Name = "sorunBildirenTcLBL";
            this.sorunBildirenTcLBL.Size = new System.Drawing.Size(220, 25);
            this.sorunBildirenTcLBL.TabIndex = 36;
            this.sorunBildirenTcLBL.Text = "Sorun Bildirenin TC : ";
            // 
            // sorunAciklamaLBL
            // 
            this.sorunAciklamaLBL.AutoSize = true;
            this.sorunAciklamaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunAciklamaLBL.Location = new System.Drawing.Point(12, 470);
            this.sorunAciklamaLBL.Name = "sorunAciklamaLBL";
            this.sorunAciklamaLBL.Size = new System.Drawing.Size(223, 25);
            this.sorunAciklamaLBL.TabIndex = 37;
            this.sorunAciklamaLBL.Text = "Sorunun Açıklaması : ";
            // 
            // sorunDurum2LBL
            // 
            this.sorunDurum2LBL.AutoSize = true;
            this.sorunDurum2LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunDurum2LBL.Location = new System.Drawing.Point(561, 416);
            this.sorunDurum2LBL.Name = "sorunDurum2LBL";
            this.sorunDurum2LBL.Size = new System.Drawing.Size(194, 25);
            this.sorunDurum2LBL.TabIndex = 38;
            this.sorunDurum2LBL.Text = "Sorunun Durumu : ";
            // 
            // cozumRaporLBL
            // 
            this.cozumRaporLBL.AutoSize = true;
            this.cozumRaporLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozumRaporLBL.Location = new System.Drawing.Point(581, 470);
            this.cozumRaporLBL.Name = "cozumRaporLBL";
            this.cozumRaporLBL.Size = new System.Drawing.Size(174, 25);
            this.cozumRaporLBL.TabIndex = 39;
            this.cozumRaporLBL.Text = "Çözüm Raporu : ";
            // 
            // sorunBildirenTcTXT
            // 
            this.sorunBildirenTcTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunBildirenTcTXT.Location = new System.Drawing.Point(241, 413);
            this.sorunBildirenTcTXT.Name = "sorunBildirenTcTXT";
            this.sorunBildirenTcTXT.ReadOnly = true;
            this.sorunBildirenTcTXT.Size = new System.Drawing.Size(269, 30);
            this.sorunBildirenTcTXT.TabIndex = 40;
            // 
            // sorunAciklamaTXT
            // 
            this.sorunAciklamaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunAciklamaTXT.Location = new System.Drawing.Point(241, 477);
            this.sorunAciklamaTXT.Name = "sorunAciklamaTXT";
            this.sorunAciklamaTXT.ReadOnly = true;
            this.sorunAciklamaTXT.Size = new System.Drawing.Size(269, 146);
            this.sorunAciklamaTXT.TabIndex = 41;
            this.sorunAciklamaTXT.Text = "";
            // 
            // sorunDurum2CB
            // 
            this.sorunDurum2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sorunDurum2CB.Enabled = false;
            this.sorunDurum2CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunDurum2CB.FormattingEnabled = true;
            this.sorunDurum2CB.Items.AddRange(new object[] {
            "Beklemede",
            "Çözüldü",
            "Çözülemedi"});
            this.sorunDurum2CB.Location = new System.Drawing.Point(771, 407);
            this.sorunDurum2CB.Name = "sorunDurum2CB";
            this.sorunDurum2CB.Size = new System.Drawing.Size(269, 39);
            this.sorunDurum2CB.TabIndex = 42;
            this.sorunDurum2CB.SelectedIndexChanged += new System.EventHandler(this.sorunDurum2CB_SelectedIndexChanged);
            // 
            // cozumRaporTXT
            // 
            this.cozumRaporTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozumRaporTXT.Location = new System.Drawing.Point(771, 477);
            this.cozumRaporTXT.Name = "cozumRaporTXT";
            this.cozumRaporTXT.ReadOnly = true;
            this.cozumRaporTXT.Size = new System.Drawing.Size(269, 146);
            this.cozumRaporTXT.TabIndex = 43;
            this.cozumRaporTXT.Text = "";
            // 
            // guncelleBTN
            // 
            this.guncelleBTN.Enabled = false;
            this.guncelleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleBTN.Location = new System.Drawing.Point(771, 638);
            this.guncelleBTN.Name = "guncelleBTN";
            this.guncelleBTN.Size = new System.Drawing.Size(269, 53);
            this.guncelleBTN.TabIndex = 44;
            this.guncelleBTN.Text = "GÜNCELLE";
            this.guncelleBTN.UseVisualStyleBackColor = true;
            this.guncelleBTN.Click += new System.EventHandler(this.guncelleBTN_Click);
            // 
            // hastaneLBL
            // 
            this.hastaneLBL.AutoSize = true;
            this.hastaneLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaneLBL.Location = new System.Drawing.Point(122, 652);
            this.hastaneLBL.Name = "hastaneLBL";
            this.hastaneLBL.Size = new System.Drawing.Size(111, 25);
            this.hastaneLBL.TabIndex = 45;
            this.hastaneLBL.Text = "Hastane : ";
            // 
            // hastaneTXT
            // 
            this.hastaneTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaneTXT.Location = new System.Drawing.Point(239, 649);
            this.hastaneTXT.Name = "hastaneTXT";
            this.hastaneTXT.ReadOnly = true;
            this.hastaneTXT.Size = new System.Drawing.Size(269, 30);
            this.hastaneTXT.TabIndex = 46;
            // 
            // SorunlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 703);
            this.Controls.Add(this.hastaneTXT);
            this.Controls.Add(this.hastaneLBL);
            this.Controls.Add(this.guncelleBTN);
            this.Controls.Add(this.cozumRaporTXT);
            this.Controls.Add(this.sorunDurum2CB);
            this.Controls.Add(this.sorunAciklamaTXT);
            this.Controls.Add(this.sorunBildirenTcTXT);
            this.Controls.Add(this.cozumRaporLBL);
            this.Controls.Add(this.sorunDurum2LBL);
            this.Controls.Add(this.sorunAciklamaLBL);
            this.Controls.Add(this.sorunBildirenTcLBL);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.sorunDurumLBL);
            this.Controls.Add(this.sorunDurumCB);
            this.Controls.Add(this.sorunlarDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SorunlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorun İşlem Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SorunlarForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sorunlarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sorunlarDGV;
        private System.Windows.Forms.ComboBox sorunDurumCB;
        private System.Windows.Forms.Label sorunDurumLBL;
        private System.Windows.Forms.Button geriBTN;
        private System.Windows.Forms.Label sorunBildirenTcLBL;
        private System.Windows.Forms.Label sorunAciklamaLBL;
        private System.Windows.Forms.Label sorunDurum2LBL;
        private System.Windows.Forms.Label cozumRaporLBL;
        private System.Windows.Forms.TextBox sorunBildirenTcTXT;
        private System.Windows.Forms.RichTextBox sorunAciklamaTXT;
        private System.Windows.Forms.ComboBox sorunDurum2CB;
        private System.Windows.Forms.RichTextBox cozumRaporTXT;
        private System.Windows.Forms.Button guncelleBTN;
        private System.Windows.Forms.Label hastaneLBL;
        private System.Windows.Forms.TextBox hastaneTXT;
    }
}