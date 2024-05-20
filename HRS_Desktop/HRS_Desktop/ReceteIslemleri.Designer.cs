namespace HRS_Desktop
{
    partial class receteIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receteIslemleri));
            this.ilaclarDGV = new System.Windows.Forms.DataGridView();
            this.ilacKaldirBTN = new System.Windows.Forms.Button();
            this.ilaclarGB = new System.Windows.Forms.GroupBox();
            this.hastaBilgileriGB = new System.Windows.Forms.GroupBox();
            this.hastaDogumYiliTXT = new System.Windows.Forms.TextBox();
            this.hastaSoyadTXT = new System.Windows.Forms.TextBox();
            this.hastaAdTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.hastaTcNoLBL = new System.Windows.Forms.Label();
            this.sorgulaBTN = new System.Windows.Forms.Button();
            this.hastaTcNoTXT = new System.Windows.Forms.TextBox();
            this.ilacEkleGB = new System.Windows.Forms.GroupBox();
            this.randomBTN = new System.Windows.Forms.Button();
            this.receteNoTXT = new System.Windows.Forms.TextBox();
            this.receteLbl = new System.Windows.Forms.Label();
            this.aciklamaLbl = new System.Windows.Forms.Label();
            this.ilacAdiLbl = new System.Windows.Forms.Label();
            this.onaylaBTN = new System.Windows.Forms.Button();
            this.aciklamaTXT = new System.Windows.Forms.RichTextBox();
            this.ilacAdCB = new System.Windows.Forms.ComboBox();
            this.yardimBTN = new System.Windows.Forms.Button();
            this.cikisBTN = new System.Windows.Forms.Button();
            this.geriBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ilaclarDGV)).BeginInit();
            this.ilaclarGB.SuspendLayout();
            this.hastaBilgileriGB.SuspendLayout();
            this.ilacEkleGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilaclarDGV
            // 
            this.ilaclarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilaclarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilaclarDGV.Location = new System.Drawing.Point(20, 32);
            this.ilaclarDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilaclarDGV.Name = "ilaclarDGV";
            this.ilaclarDGV.ReadOnly = true;
            this.ilaclarDGV.RowHeadersWidth = 51;
            this.ilaclarDGV.RowTemplate.Height = 24;
            this.ilaclarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ilaclarDGV.Size = new System.Drawing.Size(508, 444);
            this.ilaclarDGV.TabIndex = 6;
            this.ilaclarDGV.TabStop = false;
            this.ilaclarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ilaclarDGV_CellContentClick);
            // 
            // ilacKaldirBTN
            // 
            this.ilacKaldirBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ilacKaldirBTN.Location = new System.Drawing.Point(367, 487);
            this.ilacKaldirBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilacKaldirBTN.Name = "ilacKaldirBTN";
            this.ilacKaldirBTN.Size = new System.Drawing.Size(161, 49);
            this.ilacKaldirBTN.TabIndex = 7;
            this.ilacKaldirBTN.Text = "İlacı Kaldır";
            this.ilacKaldirBTN.UseVisualStyleBackColor = true;
            this.ilacKaldirBTN.Click += new System.EventHandler(this.ilacKaldirBTN_Click);
            // 
            // ilaclarGB
            // 
            this.ilaclarGB.Controls.Add(this.ilacKaldirBTN);
            this.ilaclarGB.Controls.Add(this.ilaclarDGV);
            this.ilaclarGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilaclarGB.ForeColor = System.Drawing.Color.Maroon;
            this.ilaclarGB.Location = new System.Drawing.Point(485, 23);
            this.ilaclarGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilaclarGB.Name = "ilaclarGB";
            this.ilaclarGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilaclarGB.Size = new System.Drawing.Size(555, 554);
            this.ilaclarGB.TabIndex = 3;
            this.ilaclarGB.TabStop = false;
            this.ilaclarGB.Text = "Kullandığı İlaçlar";
            // 
            // hastaBilgileriGB
            // 
            this.hastaBilgileriGB.Controls.Add(this.hastaDogumYiliTXT);
            this.hastaBilgileriGB.Controls.Add(this.hastaSoyadTXT);
            this.hastaBilgileriGB.Controls.Add(this.hastaAdTXT);
            this.hastaBilgileriGB.Controls.Add(this.label2);
            this.hastaBilgileriGB.Controls.Add(this.label1);
            this.hastaBilgileriGB.Controls.Add(this.adLbl);
            this.hastaBilgileriGB.Controls.Add(this.hastaTcNoLBL);
            this.hastaBilgileriGB.Controls.Add(this.sorgulaBTN);
            this.hastaBilgileriGB.Controls.Add(this.hastaTcNoTXT);
            this.hastaBilgileriGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaBilgileriGB.Location = new System.Drawing.Point(15, 23);
            this.hastaBilgileriGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaBilgileriGB.Name = "hastaBilgileriGB";
            this.hastaBilgileriGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaBilgileriGB.Size = new System.Drawing.Size(460, 290);
            this.hastaBilgileriGB.TabIndex = 0;
            this.hastaBilgileriGB.TabStop = false;
            // 
            // hastaDogumYiliTXT
            // 
            this.hastaDogumYiliTXT.Location = new System.Drawing.Point(187, 229);
            this.hastaDogumYiliTXT.Margin = new System.Windows.Forms.Padding(4);
            this.hastaDogumYiliTXT.Name = "hastaDogumYiliTXT";
            this.hastaDogumYiliTXT.ReadOnly = true;
            this.hastaDogumYiliTXT.Size = new System.Drawing.Size(243, 30);
            this.hastaDogumYiliTXT.TabIndex = 53;
            this.hastaDogumYiliTXT.TabStop = false;
            // 
            // hastaSoyadTXT
            // 
            this.hastaSoyadTXT.Location = new System.Drawing.Point(187, 183);
            this.hastaSoyadTXT.Margin = new System.Windows.Forms.Padding(4);
            this.hastaSoyadTXT.Name = "hastaSoyadTXT";
            this.hastaSoyadTXT.ReadOnly = true;
            this.hastaSoyadTXT.Size = new System.Drawing.Size(243, 30);
            this.hastaSoyadTXT.TabIndex = 52;
            this.hastaSoyadTXT.TabStop = false;
            // 
            // hastaAdTXT
            // 
            this.hastaAdTXT.Location = new System.Drawing.Point(187, 138);
            this.hastaAdTXT.Margin = new System.Windows.Forms.Padding(4);
            this.hastaAdTXT.Name = "hastaAdTXT";
            this.hastaAdTXT.ReadOnly = true;
            this.hastaAdTXT.Size = new System.Drawing.Size(243, 30);
            this.hastaAdTXT.TabIndex = 51;
            this.hastaAdTXT.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doğum : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Soyad : ";
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.Location = new System.Drawing.Point(117, 142);
            this.adLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(58, 25);
            this.adLbl.TabIndex = 12;
            this.adLbl.Text = "Ad : ";
            // 
            // hastaTcNoLBL
            // 
            this.hastaTcNoLBL.AutoSize = true;
            this.hastaTcNoLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hastaTcNoLBL.Location = new System.Drawing.Point(47, 32);
            this.hastaTcNoLBL.Name = "hastaTcNoLBL";
            this.hastaTcNoLBL.Size = new System.Drawing.Size(123, 25);
            this.hastaTcNoLBL.TabIndex = 11;
            this.hastaTcNoLBL.Text = "Hasta TC : ";
            // 
            // sorgulaBTN
            // 
            this.sorgulaBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sorgulaBTN.Location = new System.Drawing.Point(187, 76);
            this.sorgulaBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sorgulaBTN.Name = "sorgulaBTN";
            this.sorgulaBTN.Size = new System.Drawing.Size(244, 49);
            this.sorgulaBTN.TabIndex = 2;
            this.sorgulaBTN.Text = "Hasta Sorgula";
            this.sorgulaBTN.UseVisualStyleBackColor = true;
            this.sorgulaBTN.Click += new System.EventHandler(this.sorgulaBTN_Click);
            // 
            // hastaTcNoTXT
            // 
            this.hastaTcNoTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaTcNoTXT.Location = new System.Drawing.Point(187, 28);
            this.hastaTcNoTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaTcNoTXT.MaxLength = 11;
            this.hastaTcNoTXT.Name = "hastaTcNoTXT";
            this.hastaTcNoTXT.Size = new System.Drawing.Size(243, 30);
            this.hastaTcNoTXT.TabIndex = 1;
            this.hastaTcNoTXT.TextChanged += new System.EventHandler(this.hastaTcTXT_TextChanged);
            // 
            // ilacEkleGB
            // 
            this.ilacEkleGB.Controls.Add(this.randomBTN);
            this.ilacEkleGB.Controls.Add(this.receteNoTXT);
            this.ilacEkleGB.Controls.Add(this.receteLbl);
            this.ilacEkleGB.Controls.Add(this.aciklamaLbl);
            this.ilacEkleGB.Controls.Add(this.ilacAdiLbl);
            this.ilacEkleGB.Controls.Add(this.onaylaBTN);
            this.ilacEkleGB.Controls.Add(this.aciklamaTXT);
            this.ilacEkleGB.Controls.Add(this.ilacAdCB);
            this.ilacEkleGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacEkleGB.ForeColor = System.Drawing.Color.Maroon;
            this.ilacEkleGB.Location = new System.Drawing.Point(15, 319);
            this.ilacEkleGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilacEkleGB.Name = "ilacEkleGB";
            this.ilacEkleGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilacEkleGB.Size = new System.Drawing.Size(460, 334);
            this.ilacEkleGB.TabIndex = 1;
            this.ilacEkleGB.TabStop = false;
            // 
            // randomBTN
            // 
            this.randomBTN.Enabled = false;
            this.randomBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.randomBTN.Image = global::HRS_Desktop.Properties.Resources.refresh;
            this.randomBTN.Location = new System.Drawing.Point(396, 33);
            this.randomBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomBTN.Name = "randomBTN";
            this.randomBTN.Size = new System.Drawing.Size(35, 32);
            this.randomBTN.TabIndex = 3;
            this.randomBTN.UseVisualStyleBackColor = true;
            this.randomBTN.Click += new System.EventHandler(this.randomBTN_Click);
            // 
            // receteNoTXT
            // 
            this.receteNoTXT.Location = new System.Drawing.Point(187, 33);
            this.receteNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.receteNoTXT.Name = "receteNoTXT";
            this.receteNoTXT.ReadOnly = true;
            this.receteNoTXT.Size = new System.Drawing.Size(201, 30);
            this.receteNoTXT.TabIndex = 54;
            this.receteNoTXT.TabStop = false;
            // 
            // receteLbl
            // 
            this.receteLbl.AutoSize = true;
            this.receteLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receteLbl.Location = new System.Drawing.Point(35, 37);
            this.receteLbl.Name = "receteLbl";
            this.receteLbl.Size = new System.Drawing.Size(131, 25);
            this.receteLbl.TabIndex = 15;
            this.receteLbl.Text = "Reçete No : ";
            // 
            // aciklamaLbl
            // 
            this.aciklamaLbl.AutoSize = true;
            this.aciklamaLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aciklamaLbl.Location = new System.Drawing.Point(52, 114);
            this.aciklamaLbl.Name = "aciklamaLbl";
            this.aciklamaLbl.Size = new System.Drawing.Size(119, 25);
            this.aciklamaLbl.TabIndex = 17;
            this.aciklamaLbl.Text = "Açıklama : ";
            // 
            // ilacAdiLbl
            // 
            this.ilacAdiLbl.AutoSize = true;
            this.ilacAdiLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ilacAdiLbl.Location = new System.Drawing.Point(67, 75);
            this.ilacAdiLbl.Name = "ilacAdiLbl";
            this.ilacAdiLbl.Size = new System.Drawing.Size(103, 25);
            this.ilacAdiLbl.TabIndex = 16;
            this.ilacAdiLbl.Text = "İlaç Adı : ";
            // 
            // onaylaBTN
            // 
            this.onaylaBTN.Enabled = false;
            this.onaylaBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onaylaBTN.Location = new System.Drawing.Point(187, 270);
            this.onaylaBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onaylaBTN.Name = "onaylaBTN";
            this.onaylaBTN.Size = new System.Drawing.Size(244, 49);
            this.onaylaBTN.TabIndex = 36;
            this.onaylaBTN.Text = "Onayla";
            this.onaylaBTN.UseVisualStyleBackColor = true;
            this.onaylaBTN.Click += new System.EventHandler(this.onaylaBTN_Click);
            // 
            // aciklamaTXT
            // 
            this.aciklamaTXT.Enabled = false;
            this.aciklamaTXT.Location = new System.Drawing.Point(187, 111);
            this.aciklamaTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aciklamaTXT.Name = "aciklamaTXT";
            this.aciklamaTXT.Size = new System.Drawing.Size(243, 147);
            this.aciklamaTXT.TabIndex = 5;
            this.aciklamaTXT.Text = "";
            // 
            // ilacAdCB
            // 
            this.ilacAdCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilacAdCB.Enabled = false;
            this.ilacAdCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacAdCB.FormattingEnabled = true;
            this.ilacAdCB.Location = new System.Drawing.Point(187, 71);
            this.ilacAdCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilacAdCB.Name = "ilacAdCB";
            this.ilacAdCB.Size = new System.Drawing.Size(243, 33);
            this.ilacAdCB.TabIndex = 4;
            this.ilacAdCB.SelectedIndexChanged += new System.EventHandler(this.ilacAdCB_SelectedIndexChanged);
            // 
            // yardimBTN
            // 
            this.yardimBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yardimBTN.Location = new System.Drawing.Point(485, 588);
            this.yardimBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yardimBTN.Name = "yardimBTN";
            this.yardimBTN.Size = new System.Drawing.Size(181, 49);
            this.yardimBTN.TabIndex = 8;
            this.yardimBTN.Text = "Yardım";
            this.yardimBTN.UseVisualStyleBackColor = true;
            this.yardimBTN.Click += new System.EventHandler(this.yardimBTN_Click);
            // 
            // cikisBTN
            // 
            this.cikisBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cikisBTN.Location = new System.Drawing.Point(859, 588);
            this.cikisBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisBTN.Name = "cikisBTN";
            this.cikisBTN.Size = new System.Drawing.Size(181, 49);
            this.cikisBTN.TabIndex = 10;
            this.cikisBTN.Text = "Çıkış";
            this.cikisBTN.UseVisualStyleBackColor = true;
            this.cikisBTN.Click += new System.EventHandler(this.cikisBTN_Click);
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.geriBTN.Location = new System.Drawing.Point(672, 588);
            this.geriBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(181, 49);
            this.geriBTN.TabIndex = 9;
            this.geriBTN.Text = "Geri";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // receteIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 666);
            this.Controls.Add(this.yardimBTN);
            this.Controls.Add(this.cikisBTN);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.hastaBilgileriGB);
            this.Controls.Add(this.ilacEkleGB);
            this.Controls.Add(this.ilaclarGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "receteIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.receteIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.receteIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilaclarDGV)).EndInit();
            this.ilaclarGB.ResumeLayout(false);
            this.hastaBilgileriGB.ResumeLayout(false);
            this.hastaBilgileriGB.PerformLayout();
            this.ilacEkleGB.ResumeLayout(false);
            this.ilacEkleGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ilaclarDGV;
        private System.Windows.Forms.Button ilacKaldirBTN;
        private System.Windows.Forms.GroupBox ilaclarGB;
        private System.Windows.Forms.GroupBox hastaBilgileriGB;
        private System.Windows.Forms.TextBox hastaDogumYiliTXT;
        private System.Windows.Forms.TextBox hastaSoyadTXT;
        private System.Windows.Forms.TextBox hastaAdTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adLbl;
        private System.Windows.Forms.Label hastaTcNoLBL;
        private System.Windows.Forms.Button sorgulaBTN;
        private System.Windows.Forms.TextBox hastaTcNoTXT;
        private System.Windows.Forms.GroupBox ilacEkleGB;
        private System.Windows.Forms.Label aciklamaLbl;
        private System.Windows.Forms.Label ilacAdiLbl;
        private System.Windows.Forms.Button onaylaBTN;
        private System.Windows.Forms.RichTextBox aciklamaTXT;
        private System.Windows.Forms.ComboBox ilacAdCB;
        private System.Windows.Forms.Button yardimBTN;
        private System.Windows.Forms.Button cikisBTN;
        private System.Windows.Forms.Button geriBTN;
        private System.Windows.Forms.Button randomBTN;
        private System.Windows.Forms.TextBox receteNoTXT;
        private System.Windows.Forms.Label receteLbl;
    }
}