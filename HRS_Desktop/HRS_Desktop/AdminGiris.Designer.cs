namespace HRS_Desktop
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            this.komutTXT = new System.Windows.Forms.RichTextBox();
            this.sorguGonderBTN = new System.Windows.Forms.Button();
            this.tablolarCB = new System.Windows.Forms.ComboBox();
            this.veriTabaniDGV = new System.Windows.Forms.DataGridView();
            this.verilerGB = new System.Windows.Forms.GroupBox();
            this.sorunlarEkraninaGitBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDGV)).BeginInit();
            this.verilerGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // komutTXT
            // 
            this.komutTXT.Location = new System.Drawing.Point(41, 511);
            this.komutTXT.Name = "komutTXT";
            this.komutTXT.Size = new System.Drawing.Size(1036, 95);
            this.komutTXT.TabIndex = 1;
            this.komutTXT.Text = "";
            // 
            // sorguGonderBTN
            // 
            this.sorguGonderBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorguGonderBTN.Location = new System.Drawing.Point(863, 616);
            this.sorguGonderBTN.Name = "sorguGonderBTN";
            this.sorguGonderBTN.Size = new System.Drawing.Size(214, 71);
            this.sorguGonderBTN.TabIndex = 2;
            this.sorguGonderBTN.Text = "Sorguyu Gönder";
            this.sorguGonderBTN.UseVisualStyleBackColor = true;
            this.sorguGonderBTN.Click += new System.EventHandler(this.sorguGonderBTN_Click);
            // 
            // tablolarCB
            // 
            this.tablolarCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tablolarCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tablolarCB.FormattingEnabled = true;
            this.tablolarCB.Location = new System.Drawing.Point(29, 39);
            this.tablolarCB.Name = "tablolarCB";
            this.tablolarCB.Size = new System.Drawing.Size(1036, 39);
            this.tablolarCB.TabIndex = 3;
            this.tablolarCB.SelectedIndexChanged += new System.EventHandler(this.tablolarCB_SelectedIndexChanged);
            // 
            // veriTabaniDGV
            // 
            this.veriTabaniDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.veriTabaniDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veriTabaniDGV.Location = new System.Drawing.Point(29, 93);
            this.veriTabaniDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.veriTabaniDGV.Name = "veriTabaniDGV";
            this.veriTabaniDGV.ReadOnly = true;
            this.veriTabaniDGV.RowHeadersWidth = 51;
            this.veriTabaniDGV.RowTemplate.Height = 24;
            this.veriTabaniDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.veriTabaniDGV.Size = new System.Drawing.Size(1036, 372);
            this.veriTabaniDGV.TabIndex = 31;
            this.veriTabaniDGV.TabStop = false;
            // 
            // verilerGB
            // 
            this.verilerGB.Controls.Add(this.veriTabaniDGV);
            this.verilerGB.Controls.Add(this.tablolarCB);
            this.verilerGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verilerGB.ForeColor = System.Drawing.Color.IndianRed;
            this.verilerGB.Location = new System.Drawing.Point(12, 12);
            this.verilerGB.Name = "verilerGB";
            this.verilerGB.Size = new System.Drawing.Size(1095, 484);
            this.verilerGB.TabIndex = 32;
            this.verilerGB.TabStop = false;
            this.verilerGB.Text = "Veriler";
            // 
            // sorunlarEkraninaGitBTN
            // 
            this.sorunlarEkraninaGitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunlarEkraninaGitBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sorunlarEkraninaGitBTN.Location = new System.Drawing.Point(41, 616);
            this.sorunlarEkraninaGitBTN.Name = "sorunlarEkraninaGitBTN";
            this.sorunlarEkraninaGitBTN.Size = new System.Drawing.Size(347, 71);
            this.sorunlarEkraninaGitBTN.TabIndex = 33;
            this.sorunlarEkraninaGitBTN.Text = "Sorunlar Ekranına Git";
            this.sorunlarEkraninaGitBTN.UseVisualStyleBackColor = true;
            this.sorunlarEkraninaGitBTN.Click += new System.EventHandler(this.sorunlarEkraninaGitBTN_Click);
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 699);
            this.Controls.Add(this.sorunlarEkraninaGitBTN);
            this.Controls.Add(this.verilerGB);
            this.Controls.Add(this.sorguGonderBTN);
            this.Controls.Add(this.komutTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Yönetim Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminGiris_FormClosing);
            this.Load += new System.EventHandler(this.AdminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDGV)).EndInit();
            this.verilerGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox komutTXT;
        private System.Windows.Forms.Button sorguGonderBTN;
        private System.Windows.Forms.ComboBox tablolarCB;
        private System.Windows.Forms.DataGridView veriTabaniDGV;
        private System.Windows.Forms.GroupBox verilerGB;
        private System.Windows.Forms.Button sorunlarEkraninaGitBTN;
    }
}