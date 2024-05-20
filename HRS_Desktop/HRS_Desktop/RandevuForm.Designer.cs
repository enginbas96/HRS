namespace HRS_Desktop
{
    partial class RandevuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuForm));
            this.hastaTcNoLBL = new System.Windows.Forms.Label();
            this.hastaTcNoTXT = new System.Windows.Forms.TextBox();
            this.randevularGB = new System.Windows.Forms.GroupBox();
            this.randevularDGV = new System.Windows.Forms.DataGridView();
            this.sorgulaBTN = new System.Windows.Forms.Button();
            this.randevuOlusturCKB = new System.Windows.Forms.CheckBox();
            this.randevuOlusturGB = new System.Windows.Forms.GroupBox();
            this.randevuTarihiDTP = new System.Windows.Forms.DateTimePicker();
            this.randevuSaatleriGB = new System.Windows.Forms.GroupBox();
            this.onAltiBTN = new System.Windows.Forms.Button();
            this.onBesBTN = new System.Windows.Forms.Button();
            this.onDortBTN = new System.Windows.Forms.Button();
            this.onUcBTN = new System.Windows.Forms.Button();
            this.onBirBTN = new System.Windows.Forms.Button();
            this.onBTN = new System.Windows.Forms.Button();
            this.dokuzBTN = new System.Windows.Forms.Button();
            this.sekizBTN = new System.Windows.Forms.Button();
            this.hekimCB = new System.Windows.Forms.ComboBox();
            this.hekimLBL = new System.Windows.Forms.Label();
            this.poliklinikCB = new System.Windows.Forms.ComboBox();
            this.poliklinikLBL = new System.Windows.Forms.Label();
            this.tarihLBL = new System.Windows.Forms.Label();
            this.hastaneCB = new System.Windows.Forms.ComboBox();
            this.hastaneLBL = new System.Windows.Forms.Label();
            this.ilCB = new System.Windows.Forms.ComboBox();
            this.ilLBL = new System.Windows.Forms.Label();
            this.geriBTN = new System.Windows.Forms.Button();
            this.cikisBTN = new System.Windows.Forms.Button();
            this.yardimBTN = new System.Windows.Forms.Button();
            this.randevuOlusturBTN = new System.Windows.Forms.Button();
            this.randevuyuIptalEtBTN = new System.Windows.Forms.Button();
            this.randevularGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevularDGV)).BeginInit();
            this.randevuOlusturGB.SuspendLayout();
            this.randevuSaatleriGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastaTcNoLBL
            // 
            this.hastaTcNoLBL.AutoSize = true;
            this.hastaTcNoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaTcNoLBL.Location = new System.Drawing.Point(12, 18);
            this.hastaTcNoLBL.Name = "hastaTcNoLBL";
            this.hastaTcNoLBL.Size = new System.Drawing.Size(170, 25);
            this.hastaTcNoLBL.TabIndex = 2111;
            this.hastaTcNoLBL.Text = "T.C. Kimlik No : ";
            // 
            // hastaTcNoTXT
            // 
            this.hastaTcNoTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.hastaTcNoTXT.Location = new System.Drawing.Point(188, 16);
            this.hastaTcNoTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaTcNoTXT.MaxLength = 11;
            this.hastaTcNoTXT.Name = "hastaTcNoTXT";
            this.hastaTcNoTXT.Size = new System.Drawing.Size(221, 30);
            this.hastaTcNoTXT.TabIndex = 1;
            this.hastaTcNoTXT.TextChanged += new System.EventHandler(this.hastaTcNoTXT_TextChanged);
            // 
            // randevularGB
            // 
            this.randevularGB.Controls.Add(this.randevularDGV);
            this.randevularGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.randevularGB.ForeColor = System.Drawing.Color.Red;
            this.randevularGB.Location = new System.Drawing.Point(21, 69);
            this.randevularGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevularGB.Name = "randevularGB";
            this.randevularGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevularGB.Size = new System.Drawing.Size(520, 427);
            this.randevularGB.TabIndex = 3;
            this.randevularGB.TabStop = false;
            this.randevularGB.Text = "Tüm Randevular";
            // 
            // randevularDGV
            // 
            this.randevularDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevularDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevularDGV.Location = new System.Drawing.Point(5, 33);
            this.randevularDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevularDGV.Name = "randevularDGV";
            this.randevularDGV.ReadOnly = true;
            this.randevularDGV.RowHeadersWidth = 51;
            this.randevularDGV.RowTemplate.Height = 24;
            this.randevularDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.randevularDGV.Size = new System.Drawing.Size(508, 388);
            this.randevularDGV.TabIndex = 30;
            this.randevularDGV.TabStop = false;
            this.randevularDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevularDGV_CellContentClick);
            // 
            // sorgulaBTN
            // 
            this.sorgulaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sorgulaBTN.Location = new System.Drawing.Point(415, 7);
            this.sorgulaBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sorgulaBTN.Name = "sorgulaBTN";
            this.sorgulaBTN.Size = new System.Drawing.Size(127, 47);
            this.sorgulaBTN.TabIndex = 2;
            this.sorgulaBTN.Text = "Sorgula";
            this.sorgulaBTN.UseVisualStyleBackColor = true;
            this.sorgulaBTN.Click += new System.EventHandler(this.sorgulaBTN_Click);
            // 
            // randevuOlusturCKB
            // 
            this.randevuOlusturCKB.AutoSize = true;
            this.randevuOlusturCKB.Enabled = false;
            this.randevuOlusturCKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuOlusturCKB.Location = new System.Drawing.Point(347, 512);
            this.randevuOlusturCKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuOlusturCKB.Name = "randevuOlusturCKB";
            this.randevuOlusturCKB.Size = new System.Drawing.Size(195, 29);
            this.randevuOlusturCKB.TabIndex = 5;
            this.randevuOlusturCKB.Text = "Randevu Oluştur";
            this.randevuOlusturCKB.UseVisualStyleBackColor = true;
            this.randevuOlusturCKB.CheckedChanged += new System.EventHandler(this.randevuOlusturCKB_CheckedChanged);
            // 
            // randevuOlusturGB
            // 
            this.randevuOlusturGB.Controls.Add(this.randevuTarihiDTP);
            this.randevuOlusturGB.Controls.Add(this.randevuSaatleriGB);
            this.randevuOlusturGB.Controls.Add(this.hekimCB);
            this.randevuOlusturGB.Controls.Add(this.hekimLBL);
            this.randevuOlusturGB.Controls.Add(this.poliklinikCB);
            this.randevuOlusturGB.Controls.Add(this.poliklinikLBL);
            this.randevuOlusturGB.Controls.Add(this.tarihLBL);
            this.randevuOlusturGB.Controls.Add(this.hastaneCB);
            this.randevuOlusturGB.Controls.Add(this.hastaneLBL);
            this.randevuOlusturGB.Controls.Add(this.ilCB);
            this.randevuOlusturGB.Controls.Add(this.ilLBL);
            this.randevuOlusturGB.Enabled = false;
            this.randevuOlusturGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.randevuOlusturGB.ForeColor = System.Drawing.Color.Red;
            this.randevuOlusturGB.Location = new System.Drawing.Point(553, 69);
            this.randevuOlusturGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuOlusturGB.Name = "randevuOlusturGB";
            this.randevuOlusturGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuOlusturGB.Size = new System.Drawing.Size(573, 427);
            this.randevuOlusturGB.TabIndex = 6;
            this.randevuOlusturGB.TabStop = false;
            this.randevuOlusturGB.Text = "Randevu Oluştur";
            // 
            // randevuTarihiDTP
            // 
            this.randevuTarihiDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.randevuTarihiDTP.Location = new System.Drawing.Point(151, 132);
            this.randevuTarihiDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuTarihiDTP.Name = "randevuTarihiDTP";
            this.randevuTarihiDTP.Size = new System.Drawing.Size(391, 30);
            this.randevuTarihiDTP.TabIndex = 9;
            this.randevuTarihiDTP.ValueChanged += new System.EventHandler(this.randevuTarihiDTP_ValueChanged);
            // 
            // randevuSaatleriGB
            // 
            this.randevuSaatleriGB.Controls.Add(this.onAltiBTN);
            this.randevuSaatleriGB.Controls.Add(this.onBesBTN);
            this.randevuSaatleriGB.Controls.Add(this.onDortBTN);
            this.randevuSaatleriGB.Controls.Add(this.onUcBTN);
            this.randevuSaatleriGB.Controls.Add(this.onBirBTN);
            this.randevuSaatleriGB.Controls.Add(this.onBTN);
            this.randevuSaatleriGB.Controls.Add(this.dokuzBTN);
            this.randevuSaatleriGB.Controls.Add(this.sekizBTN);
            this.randevuSaatleriGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.randevuSaatleriGB.ForeColor = System.Drawing.Color.Red;
            this.randevuSaatleriGB.Location = new System.Drawing.Point(5, 268);
            this.randevuSaatleriGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuSaatleriGB.Name = "randevuSaatleriGB";
            this.randevuSaatleriGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuSaatleriGB.Size = new System.Drawing.Size(561, 153);
            this.randevuSaatleriGB.TabIndex = 944;
            this.randevuSaatleriGB.TabStop = false;
            this.randevuSaatleriGB.Text = "Randevu Saatleri";
            // 
            // onAltiBTN
            // 
            this.onAltiBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onAltiBTN.Location = new System.Drawing.Point(419, 94);
            this.onAltiBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onAltiBTN.Name = "onAltiBTN";
            this.onAltiBTN.Size = new System.Drawing.Size(115, 47);
            this.onAltiBTN.TabIndex = 20;
            this.onAltiBTN.Text = "16 : 00";
            this.onAltiBTN.UseVisualStyleBackColor = true;
            // 
            // onBesBTN
            // 
            this.onBesBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onBesBTN.Location = new System.Drawing.Point(288, 94);
            this.onBesBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onBesBTN.Name = "onBesBTN";
            this.onBesBTN.Size = new System.Drawing.Size(115, 47);
            this.onBesBTN.TabIndex = 19;
            this.onBesBTN.Text = "15 : 00";
            this.onBesBTN.UseVisualStyleBackColor = true;
            // 
            // onDortBTN
            // 
            this.onDortBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onDortBTN.Location = new System.Drawing.Point(157, 94);
            this.onDortBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onDortBTN.Name = "onDortBTN";
            this.onDortBTN.Size = new System.Drawing.Size(115, 47);
            this.onDortBTN.TabIndex = 18;
            this.onDortBTN.Text = "14 : 00";
            this.onDortBTN.UseVisualStyleBackColor = true;
            // 
            // onUcBTN
            // 
            this.onUcBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onUcBTN.Location = new System.Drawing.Point(27, 94);
            this.onUcBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onUcBTN.Name = "onUcBTN";
            this.onUcBTN.Size = new System.Drawing.Size(115, 47);
            this.onUcBTN.TabIndex = 17;
            this.onUcBTN.Text = "13 : 00";
            this.onUcBTN.UseVisualStyleBackColor = true;
            // 
            // onBirBTN
            // 
            this.onBirBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onBirBTN.Location = new System.Drawing.Point(419, 31);
            this.onBirBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onBirBTN.Name = "onBirBTN";
            this.onBirBTN.Size = new System.Drawing.Size(115, 47);
            this.onBirBTN.TabIndex = 16;
            this.onBirBTN.Text = "11 : 00";
            this.onBirBTN.UseVisualStyleBackColor = true;
            // 
            // onBTN
            // 
            this.onBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onBTN.Location = new System.Drawing.Point(288, 31);
            this.onBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onBTN.Name = "onBTN";
            this.onBTN.Size = new System.Drawing.Size(115, 47);
            this.onBTN.TabIndex = 15;
            this.onBTN.Text = "10 : 00";
            this.onBTN.UseVisualStyleBackColor = true;
            // 
            // dokuzBTN
            // 
            this.dokuzBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dokuzBTN.Location = new System.Drawing.Point(157, 31);
            this.dokuzBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dokuzBTN.Name = "dokuzBTN";
            this.dokuzBTN.Size = new System.Drawing.Size(115, 47);
            this.dokuzBTN.TabIndex = 14;
            this.dokuzBTN.Text = "9 : 00";
            this.dokuzBTN.UseVisualStyleBackColor = true;
            // 
            // sekizBTN
            // 
            this.sekizBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sekizBTN.Location = new System.Drawing.Point(27, 31);
            this.sekizBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sekizBTN.Name = "sekizBTN";
            this.sekizBTN.Size = new System.Drawing.Size(115, 47);
            this.sekizBTN.TabIndex = 13;
            this.sekizBTN.Text = "8 : 00";
            this.sekizBTN.UseVisualStyleBackColor = true;
            // 
            // hekimCB
            // 
            this.hekimCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hekimCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.hekimCB.FormattingEnabled = true;
            this.hekimCB.Location = new System.Drawing.Point(151, 217);
            this.hekimCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hekimCB.Name = "hekimCB";
            this.hekimCB.Size = new System.Drawing.Size(391, 33);
            this.hekimCB.TabIndex = 11;
            this.hekimCB.SelectedIndexChanged += new System.EventHandler(this.hekimCB_SelectedIndexChanged);
            // 
            // hekimLBL
            // 
            this.hekimLBL.AutoSize = true;
            this.hekimLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hekimLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hekimLBL.Location = new System.Drawing.Point(53, 220);
            this.hekimLBL.Name = "hekimLBL";
            this.hekimLBL.Size = new System.Drawing.Size(91, 25);
            this.hekimLBL.TabIndex = 1545;
            this.hekimLBL.Text = "Hekim : ";
            // 
            // poliklinikCB
            // 
            this.poliklinikCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poliklinikCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.poliklinikCB.FormattingEnabled = true;
            this.poliklinikCB.Location = new System.Drawing.Point(151, 174);
            this.poliklinikCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poliklinikCB.Name = "poliklinikCB";
            this.poliklinikCB.Size = new System.Drawing.Size(391, 33);
            this.poliklinikCB.TabIndex = 10;
            this.poliklinikCB.SelectedIndexChanged += new System.EventHandler(this.poliklinikCB_SelectedIndexChanged);
            // 
            // poliklinikLBL
            // 
            this.poliklinikLBL.AutoSize = true;
            this.poliklinikLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.poliklinikLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.poliklinikLBL.Location = new System.Drawing.Point(29, 181);
            this.poliklinikLBL.Name = "poliklinikLBL";
            this.poliklinikLBL.Size = new System.Drawing.Size(116, 25);
            this.poliklinikLBL.TabIndex = 1354;
            this.poliklinikLBL.Text = "Poliklinik : ";
            // 
            // tarihLBL
            // 
            this.tarihLBL.AutoSize = true;
            this.tarihLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tarihLBL.Location = new System.Drawing.Point(64, 137);
            this.tarihLBL.Name = "tarihLBL";
            this.tarihLBL.Size = new System.Drawing.Size(81, 25);
            this.tarihLBL.TabIndex = 745;
            this.tarihLBL.Text = "Tarih : ";
            // 
            // hastaneCB
            // 
            this.hastaneCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hastaneCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.hastaneCB.FormattingEnabled = true;
            this.hastaneCB.Location = new System.Drawing.Point(151, 89);
            this.hastaneCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaneCB.Name = "hastaneCB";
            this.hastaneCB.Size = new System.Drawing.Size(391, 33);
            this.hastaneCB.TabIndex = 8;
            this.hastaneCB.SelectedIndexChanged += new System.EventHandler(this.hastaneCB_SelectedIndexChanged);
            // 
            // hastaneLBL
            // 
            this.hastaneLBL.AutoSize = true;
            this.hastaneLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaneLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hastaneLBL.Location = new System.Drawing.Point(35, 91);
            this.hastaneLBL.Name = "hastaneLBL";
            this.hastaneLBL.Size = new System.Drawing.Size(111, 25);
            this.hastaneLBL.TabIndex = 544;
            this.hastaneLBL.Text = "Hastane : ";
            // 
            // ilCB
            // 
            this.ilCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ilCB.FormattingEnabled = true;
            this.ilCB.Location = new System.Drawing.Point(151, 44);
            this.ilCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ilCB.Name = "ilCB";
            this.ilCB.Size = new System.Drawing.Size(391, 33);
            this.ilCB.TabIndex = 7;
            this.ilCB.SelectedIndexChanged += new System.EventHandler(this.ilCB_SelectedIndexChanged);
            // 
            // ilLBL
            // 
            this.ilLBL.AutoSize = true;
            this.ilLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ilLBL.Location = new System.Drawing.Point(103, 47);
            this.ilLBL.Name = "ilLBL";
            this.ilLBL.Size = new System.Drawing.Size(42, 25);
            this.ilLBL.TabIndex = 355;
            this.ilLBL.Text = "İl : ";
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.geriBTN.Location = new System.Drawing.Point(867, 12);
            this.geriBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(127, 47);
            this.geriBTN.TabIndex = 23;
            this.geriBTN.Text = "Geri";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // cikisBTN
            // 
            this.cikisBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cikisBTN.Location = new System.Drawing.Point(999, 12);
            this.cikisBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisBTN.Name = "cikisBTN";
            this.cikisBTN.Size = new System.Drawing.Size(127, 47);
            this.cikisBTN.TabIndex = 24;
            this.cikisBTN.Text = "Çıkış";
            this.cikisBTN.UseVisualStyleBackColor = true;
            this.cikisBTN.Click += new System.EventHandler(this.cikisBTN_Click);
            // 
            // yardimBTN
            // 
            this.yardimBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yardimBTN.Location = new System.Drawing.Point(733, 12);
            this.yardimBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yardimBTN.Name = "yardimBTN";
            this.yardimBTN.Size = new System.Drawing.Size(127, 47);
            this.yardimBTN.TabIndex = 22;
            this.yardimBTN.Text = "Yardım";
            this.yardimBTN.UseVisualStyleBackColor = true;
            this.yardimBTN.Click += new System.EventHandler(this.yardimBTN_Click);
            // 
            // randevuOlusturBTN
            // 
            this.randevuOlusturBTN.Enabled = false;
            this.randevuOlusturBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.randevuOlusturBTN.Location = new System.Drawing.Point(867, 502);
            this.randevuOlusturBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuOlusturBTN.Name = "randevuOlusturBTN";
            this.randevuOlusturBTN.Size = new System.Drawing.Size(260, 47);
            this.randevuOlusturBTN.TabIndex = 21;
            this.randevuOlusturBTN.Text = "Randevu Oluştur";
            this.randevuOlusturBTN.UseVisualStyleBackColor = true;
            this.randevuOlusturBTN.Click += new System.EventHandler(this.randevuOlusturBTN_Click);
            // 
            // randevuyuIptalEtBTN
            // 
            this.randevuyuIptalEtBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.randevuyuIptalEtBTN.Location = new System.Drawing.Point(21, 502);
            this.randevuyuIptalEtBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuyuIptalEtBTN.Name = "randevuyuIptalEtBTN";
            this.randevuyuIptalEtBTN.Size = new System.Drawing.Size(247, 47);
            this.randevuyuIptalEtBTN.TabIndex = 4;
            this.randevuyuIptalEtBTN.Text = "Randevuyu İptal Et";
            this.randevuyuIptalEtBTN.UseVisualStyleBackColor = true;
            this.randevuyuIptalEtBTN.Click += new System.EventHandler(this.randevuyuIptalEtBTN_Click);
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 561);
            this.Controls.Add(this.randevuyuIptalEtBTN);
            this.Controls.Add(this.randevuOlusturBTN);
            this.Controls.Add(this.yardimBTN);
            this.Controls.Add(this.cikisBTN);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.randevuOlusturGB);
            this.Controls.Add(this.randevuOlusturCKB);
            this.Controls.Add(this.sorgulaBTN);
            this.Controls.Add(this.randevularGB);
            this.Controls.Add(this.hastaTcNoTXT);
            this.Controls.Add(this.hastaTcNoLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandevuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu İşlemleri Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandevuForm_FormClosing);
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            this.randevularGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.randevularDGV)).EndInit();
            this.randevuOlusturGB.ResumeLayout(false);
            this.randevuOlusturGB.PerformLayout();
            this.randevuSaatleriGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hastaTcNoLBL;
        private System.Windows.Forms.TextBox hastaTcNoTXT;
        private System.Windows.Forms.GroupBox randevularGB;
        private System.Windows.Forms.DataGridView randevularDGV;
        private System.Windows.Forms.Button sorgulaBTN;
        private System.Windows.Forms.CheckBox randevuOlusturCKB;
        private System.Windows.Forms.GroupBox randevuOlusturGB;
        private System.Windows.Forms.ComboBox hastaneCB;
        private System.Windows.Forms.Label hastaneLBL;
        private System.Windows.Forms.ComboBox ilCB;
        private System.Windows.Forms.Label ilLBL;
        private System.Windows.Forms.Label tarihLBL;
        private System.Windows.Forms.GroupBox randevuSaatleriGB;
        private System.Windows.Forms.Button onAltiBTN;
        private System.Windows.Forms.Button onBesBTN;
        private System.Windows.Forms.Button onDortBTN;
        private System.Windows.Forms.Button onUcBTN;
        private System.Windows.Forms.Button onBirBTN;
        private System.Windows.Forms.Button onBTN;
        private System.Windows.Forms.Button dokuzBTN;
        private System.Windows.Forms.Button sekizBTN;
        private System.Windows.Forms.ComboBox hekimCB;
        private System.Windows.Forms.Label hekimLBL;
        private System.Windows.Forms.ComboBox poliklinikCB;
        private System.Windows.Forms.Label poliklinikLBL;
        private System.Windows.Forms.Button geriBTN;
        private System.Windows.Forms.Button cikisBTN;
        private System.Windows.Forms.Button yardimBTN;
        private System.Windows.Forms.Button randevuOlusturBTN;
        private System.Windows.Forms.DateTimePicker randevuTarihiDTP;
        private System.Windows.Forms.Button randevuyuIptalEtBTN;
    }
}