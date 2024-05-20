using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRS_Desktop
{
    public partial class RandevuForm : Form
    {
        string CalisanTc;
        string randevuSaati = "";
        string randevuTarihi;
        string doktorTC;
        string poliklinik = "";
        string tarih = "";
        string saat = "";
        string doktor = "";
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");

        public RandevuForm(string kullanici)
        {
            InitializeComponent();
            CalisanTc = kullanici;

            //Tüm butonları aynı metoda atandı
            sekizBTN.Click += Button_Click;
            dokuzBTN.Click += Button_Click;
            onBTN.Click += Button_Click;
            onBirBTN.Click += Button_Click;
            onUcBTN.Click += Button_Click;
            onDortBTN.Click += Button_Click;
            onBesBTN.Click += Button_Click;
            onAltiBTN.Click += Button_Click;

            //RandevuTarihiDTP'de tarih sınırlamaları koyuldu
            randevuTarihiDTP.MinDate = DateTime.Now.AddDays(1);
            randevuTarihiDTP.MaxDate = DateTime.Now.AddDays(16);
        }

        //Yardım Butonu -> Click
        private void yardimBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TC kimlik numarasını yazılarak sorgula butonuna basıldığında kişinin randevu geçmişini görüntülenebilinir.\n\nRandevu oluştur kutucuğu işaretlenerek TC kimlik numarası yazılı olan kişinin üzerine seçilen kriterlerde randevu alınabilir.\n\nAnlaşılmayan durumlar veya karşılaşılan problemler için teknik ekip ile iletişime geçiniz. ", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Geri Butonu -> Click
        private void geriBTN_Click(object sender, EventArgs e)
        {
            CalisanGirisForm calisanGiris = new CalisanGirisForm(CalisanTc);
            calisanGiris.Show();
            this.Hide();
        }

        //Çıkış Butonu -> Click
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form -> Closing
        private void RandevuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Form -> Load
        private void RandevuForm_Load(object sender, EventArgs e)
        {
            ilCB.Items.Clear();
            butonKontrol2();
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT il FROM iller", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    ilCB.Items.Add(okutucu["il"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0001", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Sorgula Butonu -> Click
        //Butona basıldığında mevcut randevuları listeler
        private void sorgulaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                randevuOlusturCKB.Enabled = false;
                randevuOlusturCKB.Checked = false;
                randevuOlusturBTN.Enabled = false;
                ilCB.SelectedIndex = -1;
                hastaneCB.Text = "";
                hastaneCB.Items.Clear();
                poliklinikCB.Text = "";
                poliklinikCB.Items.Clear();
                hekimCB.Text = "";
                hekimCB.Items.Clear();
                butonKontrol2();

                bool hastaVarMi = false;
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM hasta where tc = '" + hastaTcNoTXT.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    hastaVarMi = true;
                }
                if (hastaVarMi == false)
                {
                    MessageBox.Show("Belirtilen TC kimlik numarasına ait bir hasta bulunamamıştır, lütfen kotnrol edip tekrar deneyiniz.", "Hasta bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    randevuOlusturCKB.Enabled = true;
                    randevuVerileriniCek();
                    baglanti.Close();
                }
                hastaVarMi = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0002", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Randevular Data Grid View Tablosundan veri seçimi
        private void randevularDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            if (randevularDGV.SelectedRows.Count > 0)
            {
                poliklinik = randevularDGV.SelectedRows[0].Cells["Poliklinik"].Value.ToString();
                tarih = randevularDGV.SelectedRows[0].Cells["Tarih"].Value.ToString();
                saat = randevularDGV.SelectedRows[0].Cells["Saat"].Value.ToString();
                doktor = randevularDGV.SelectedRows[0].Cells["Doktor"].Value.ToString();
                MessageBox.Show("Seçtiğiniz Randevu \nPoliklinik : " + poliklinik + "\nTarih : " + tarih + "\nSaat : " + saat + "\nDoktor : " + doktor);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir randevu seçip işleminizi tekrar ediniz.");
            }
        }

        //Randevuyu İptal Et Butonu -> Click
        //Seçili randevuyu iptal eder
        private void randevuyuIptalEtBTN_Click(object sender, EventArgs e)
        {
            if (poliklinik != "")
            {
                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("Select tc from doktorlar where adsoyad ='" + doktor + "'", baglanti);
                    MySqlDataReader okutucu = komut.ExecuteReader();
                    while (okutucu.Read())
                    {
                        doktorTC = okutucu["tc"].ToString();
                    }
                    baglanti.Close();

                    baglanti.Open();
                    komut = new MySqlCommand("DELETE FROM randevular where doktorTC = '" + doktorTC + "' AND tarih ='" + tarih + "' AND saat ='" + saat + "'", baglanti);
                    okutucu = komut.ExecuteReader();
                    MessageBox.Show("Başarı ile iptal edildi.");
                    baglanti.Close();

                    randevuVerileriniCek();
                    doktorTC = "";
                    hekimCB.SelectedIndex = -1;
                    butonKontrol2();
                    randevuOlusturBTN.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0003", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir randevu seçip işleminizi tekrar ediniz.");
            }
        }

        //Randevu Oluştur CheckBox -> Changed
        private void randevuOlusturCKB_CheckedChanged(object sender, EventArgs e)
        {
            if (randevuOlusturGB.Enabled == false) { randevuOlusturGB.Enabled = true; }
            else if (randevuOlusturGB.Enabled == true) { randevuOlusturGB.Enabled = false; randevuOlusturBTN.Enabled = false; }

            ilCB.SelectedIndex = -1;
            hastaneCB.Text = "";
            hastaneCB.Items.Clear();
            poliklinikCB.Text = "";
            poliklinikCB.Items.Clear();
            hekimCB.Text = "";
            hekimCB.Items.Clear();
            butonKontrol2();

        } 

        //ilCB -> Changed
        private void ilCB_SelectedIndexChanged(object sender, EventArgs e)
        {      
            randevuOlusturBTN.Enabled = false;

            if (ilCB.Text != "") 
            {
                hastaneCB.Text = "";
                hastaneCB.Items.Clear();
                poliklinikCB.Text = "";
                poliklinikCB.Items.Clear();
                hekimCB.Text = "";
                hekimCB.Items.Clear();
                butonKontrol2();

                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("SELECT * FROM hastaneler WHERE il ='" + ilCB.Text + "'", baglanti);
                    MySqlDataReader okutucu = komut.ExecuteReader();
                    while (okutucu.Read())
                    {
                        hastaneCB.Items.Add(okutucu["hastaneAdi"].ToString());
                    }
                    baglanti.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0004", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
        }

        //hastaneCB -> Changed
        private void hastaneCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevuOlusturBTN.Enabled = false;

            poliklinikCB.Text = "";
            poliklinikCB.Items.Clear();
            hekimCB.Text = "";
            hekimCB.Items.Clear();
            butonKontrol2();

            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM poliklinikler WHERE hastaneAdi ='" + hastaneCB.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    poliklinikCB.Items.Add(okutucu["poliklinikAdi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0005", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //poliklinikCB -> Changed
        private void poliklinikCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevuOlusturBTN.Enabled = false;

            hekimCB.Text = "";
            hekimCB.Items.Clear();
            try
            {
                butonKontrol2();
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM doktorlar WHERE hastaneAdi ='" + hastaneCB.Text + "' AND birim ='" + poliklinikCB.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    hekimCB.Items.Add(okutucu["adsoyad"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0006", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        //hekimCB -> Changed
        private void hekimCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevuOlusturBTN.Enabled = false;

            try
            {
                butonKontrol();
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM doktorlar where hastaneAdi = '" + hastaneCB.Text + "' AND birim = '" + poliklinikCB.Text + "' AND adsoyad = '" + hekimCB.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    doktorTC = okutucu["tc"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0007", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM randevular where doktorTC ='" + doktorTC + "' AND tarih ='" + randevuTarihi + "' AND poliklinik ='" + poliklinikCB.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    randevuKontrol(okutucu["saat"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0008", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }   

        //randevuTarihiDTP -> Changed
        //Randevu Tarihi seçildi
        private void randevuTarihiDTP_ValueChanged(object sender, EventArgs e)
        {
            randevuOlusturBTN.Enabled = false;

            poliklinikCB.Text = "";
            poliklinikCB.Items.Clear();
            hekimCB.Text = "";
            hekimCB.Items.Clear();
            butonKontrol2();
            randevuTarihi = randevuTarihiDTP.Value.Date.ToString("d");
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM poliklinikler WHERE hastaneAdi ='" + hastaneCB.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    poliklinikCB.Items.Add(okutucu["poliklinikAdi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0009", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Randevu Oluştur Butonu -> Click
        private void randevuOlusturBTN_Click(object sender, EventArgs e)
        {
            //Randevu tarihini kontrol et
            DateTime seciliTarih = randevuTarihiDTP.Value;
            if (haftasonuKontrol(seciliTarih))
            {
                try
                {
                    MessageBox.Show("Randevu tarihleri hafta içi olmak zorundadır. Lütfen tarihi düzeltip tekrar deneyiniz.", "Geçersiz Tarih Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    randevuTarihiDTP.Value = ilkPazartesiyeGit(DateTime.Now.AddDays(1));
                    butonKontrol2();
                    hekimCB.SelectedIndex = -1;
                    randevuSaati = "";
                    return;
                }
                catch
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0010", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                randevuTarihi = randevuTarihiDTP.Value.Date.ToString("d");
            }

            bool hastaVarMi = false;
            bool ciftRadnevu = false;

            //Hasta var mı kontrol et
            if (hastaTcNoTXT.Text != "")
            {
                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("select * from hasta where tc ='" + hastaTcNoTXT.Text + "'", baglanti);
                    MySqlDataReader okutucu = komut.ExecuteReader();
                    while (okutucu.Read())
                    {
                        hastaVarMi = true;
                    }
                    if (hastaVarMi == false)
                    {
                        MessageBox.Show("Bu TC kimlik numarasına ait bir kayıt bulunamadı.", "Kayıt bulunamadı.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0011", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen TC kimlik numarasını doğru ve eksiksiz giriniz.", "Hatalı TC sorgulama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Randevu var mı kontrol et
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("Select * from randevular where hastaTC ='" + hastaTcNoTXT.Text + "' AND tarih ='" + randevuTarihi + "' AND poliklinik ='" + poliklinikCB.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    ciftRadnevu = true;
                }
                if (ciftRadnevu == true)
                {
                    MessageBox.Show("Bu hastanın aynı tarihte zaten bir randevusu bulunuyor.", "Randevu zaten mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0012", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Randevusu yok ise randevu ver
            if (hastaVarMi == true && ciftRadnevu == false)
            {
                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    if (randevuSaati == "")
                    {
                        MessageBox.Show("Lütfen randevu saatinizi seçiniz.", "Geçersiz randevu saati.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MySqlCommand komut = new MySqlCommand("INSERT INTO `randevular` (`hastaTC`, `doktorTC`, `hastaneAdi`, `tarih`, `saat`, `poliklinik`) VALUES('" + hastaTcNoTXT.Text + "', '" + doktorTC + "', '" + hastaneCB.Text + "', '" + randevuTarihi + "', '" + randevuSaati + "', '" + poliklinikCB.Text + "')", baglanti);
                    MySqlDataReader okutucu = komut.ExecuteReader();
                    baglanti.Close();

                    baglanti.Open();
                    komut = new MySqlCommand("SELECT * FROM randevular where doktorTC ='" + doktorTC + "' AND tarih ='" + randevuTarihi + "' AND poliklinik ='" + poliklinikCB.Text + "'", baglanti);
                    okutucu = komut.ExecuteReader();
                    while (okutucu.Read())
                    {
                        randevuKontrol(okutucu["saat"].ToString());
                    }
                    baglanti.Close();

                    randevuVerileriniCek();
                    randevuSaati = "";
                    randevuOlusturBTN.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0013", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        /*   METOTLAR ------------------------------------------------------------------------------------------------------ */

        //Seçili butona göre saat ayarlama metodu
        private void Button_Click(object sender, EventArgs e)
        {
            Button saat = (Button)sender;
            if (saat.Name == "sekizBTN") { randevuSaati = "8"; }
            if (saat.Name == "dokuzBTN") { randevuSaati = "9"; }
            if (saat.Name == "onBTN") { randevuSaati = "10"; }
            if (saat.Name == "onBirBTN") { randevuSaati = "11"; }
            if (saat.Name == "onUcBTN") { randevuSaati = "13"; }
            if (saat.Name == "onDortBTN") { randevuSaati = "14"; }
            if (saat.Name == "onBesBTN") { randevuSaati = "15"; }
            if (saat.Name == "onAltiBTN") { randevuSaati = "16"; }
            MessageBox.Show("Randevu Saati " + randevuSaati + ":00 olarak değiştirildi.");
            randevuOlusturBTN.Enabled = true;
        }

        //Tarih haftasonu mu? metodu
        private bool haftasonuKontrol(DateTime gun)
        {
            return gun.DayOfWeek == DayOfWeek.Saturday || gun.DayOfWeek == DayOfWeek.Sunday;
        }

        //Pazartesiye yuvarla metodu
        private DateTime ilkPazartesiyeGit(DateTime isaretliTarih)
        {
            while (isaretliTarih.DayOfWeek != DayOfWeek.Monday)
            {
                isaretliTarih = isaretliTarih.AddDays(1);
            }
            return isaretliTarih;
        }

        //Uygun butonları deaktif et metodu
        private void randevuKontrol(string randevuSaati)
        {
            if (randevuSaati == "8")
            {
                sekizBTN.Enabled = false;
            }
            else if (randevuSaati == "9")
            {
                dokuzBTN.Enabled = false;
            }
            else if (randevuSaati == "10")
            {
                onBTN.Enabled = false;
            }
            else if (randevuSaati == "11")
            {
                onBirBTN.Enabled = false;
            }
            else if (randevuSaati == "13")
            {
                onUcBTN.Enabled = false;
            }
            else if (randevuSaati == "14")
            {
                onDortBTN.Enabled = false;
            }
            else if (randevuSaati == "15")
            {
                onBesBTN.Enabled = false;
            }
            else if (randevuSaati == "16")
            {
                onAltiBTN.Enabled = false;
            }
        }

        //Veritabanından Verileri Çekme metodu
        private void randevuVerileriniCek()
        {
            randevularDGV.RowHeadersVisible = false;
            randevularDGV.DataSource = null;
            randevularDGV.Rows.Clear();
            poliklinik = "";
            tarih = "";
            saat = "";
            doktor = "";

            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT r.poliklinik, r.tarih, r.saat, d.adsoyad AS Doktor FROM randevular r join doktorlar d ON r.doktorTC = d.tc where hastaTC= '" + hastaTcNoTXT.Text + "'", baglanti);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Poliklinik");
                dataTable.Columns.Add("Tarih");
                dataTable.Columns.Add("Saat");
                dataTable.Columns.Add("Doktor");

                baglanti.Close();
                baglanti.Open();
                dataAdapter.Fill(dataTable);
                randevularDGV.DataSource = dataTable;
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 2x0014", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Butonları Resetle Metodu
        private void butonKontrol()
        {
            sekizBTN.Enabled = true;
            dokuzBTN.Enabled = true;
            onBTN.Enabled = true;
            onBirBTN.Enabled = true;
            onUcBTN.Enabled = true;
            onDortBTN.Enabled = true;
            onBesBTN.Enabled = true;
            onAltiBTN.Enabled = true;
        }
        //Butonları Resetle Metodu - 2
        private void butonKontrol2()
        {
            sekizBTN.Enabled = false;
            dokuzBTN.Enabled = false;
            onBTN.Enabled = false;
            onBirBTN.Enabled = false;
            onUcBTN.Enabled = false;
            onDortBTN.Enabled = false;
            onBesBTN.Enabled = false;
            onAltiBTN.Enabled = false;
        }


        /*   KISITLAR------------------------------------------------------------------------------------------------------ */

        //TC Rakamdan başka karakter girilemez
        private void hastaTcNoTXT_TextChanged(object sender, EventArgs e)
        {
            string kontrolText = hastaTcNoTXT.Text;
            try
            {
                for (int i = 0; i < kontrolText.Length; i++)
                {
                    if (!char.IsDigit(kontrolText[i]))
                    {
                        hastaTcNoTXT.Text = hastaTcNoTXT.Text.Remove(i, 1);
                        hastaTcNoTXT.SelectionStart = i;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}