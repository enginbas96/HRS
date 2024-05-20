using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRS_Desktop
{
    public partial class DoktorIslemleri : Form
    {
        string DoktorTC;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");
        public DoktorIslemleri(string tc)
        {            
            InitializeComponent();
            DoktorTC = tc;
        }

        //Yardım Butonu -> Click
        private void yardimBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifre İşlemleri kısmından alanları doldurarak kendinize yeni bir şifre oluşturabiliriniz. \n\nBilgilerim kısmında kendiniz hakkında bilgileri göreceksiniz. \n\nSorun Bildir kısmından hesabınızla ilgili veya program ile ilgili sorunları teknik ekip ile paylaşabilirsiniz.", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Geri Butonu -> Click
        private void geriBTN_Click(object sender, EventArgs e)
        {

            DoktorGiris doktorGiris = new DoktorGiris(DoktorTC);
            doktorGiris.Show();
            this.Hide();
        }     

        //Çıkış Butonu -> Click
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form -> Closing
        private void DoktorIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Form -> Load
        private void DoktorIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM doktorlar where tc = '" + DoktorTC + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    tcText.Text = okutucu["tc"].ToString();
                    adSoyadText.Text = okutucu["unvan"].ToString() + okutucu["adsoyad"].ToString();
                    mailText.Text = okutucu["eposta"].ToString();
                    birimText.Text = okutucu["birim"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 4x0001", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Şifre Değiştir Butonu -> Click
        private void sifreDegistirBTN_Click(object sender, EventArgs e)
        {
            bool sifreDogruMu = false;
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM doktorlar where tc = '" + DoktorTC + "' AND sifre = '" + eskiSifreTXT.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    sifreDogruMu = true;
                }
                baglanti.Close();
                if (sifreDogruMu == false)
                {
                    MessageBox.Show("Lütfen eski şifrenizi doğru bir şekilde giriniz.", "Hatalı Eski Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sifreTXT.Text != sifreTekrarTXT.Text)
                {
                    MessageBox.Show("Girdiğiniz yeni şifreler uyuşmuyor lütfen doğru bir şekilde tekrar giriniz.", "Uyuşmaz Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sifreTXT.Text.Length <= 8)
                {
                    MessageBox.Show("Lütfen şifrenizi 9 karakter ve üstü olarak ayarlayınız", "Kısa Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((sifreDogruMu == true) && (sifreTXT.Text == sifreTekrarTXT.Text))
                {
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand komut2 = new MySqlCommand("UPDATE doktorlar set sifre='" + sifreTXT.Text + "' where tc ='" + DoktorTC + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz başarıyla değiştirilmiştir. Dilerseniz yeni şifrenizi bir yere not alınız.", "Şifre Değiştirildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eskiSifreTXT.Text = "";
                    sifreTXT.Text = "";
                    sifreTekrarTXT.Text = "";
                    sifreDogruMu = false;
                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 4x0002", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Gönder Butonu -> Click
        private void gonderBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (sorunTXT.Text.Length <= 30)
                {
                    MessageBox.Show("Lütfen en az 30 karakter içerek şekilde sorununuzu anlatınız.", "Sorun Mesajı Çok Kısa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Doktorun çalıştığı hastane alındı
                    string hastaneAdi = "";
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("SELECT hastaneAdi FROM doktorlar where tc = '" + DoktorTC + "'", baglanti);
                    MySqlDataReader okutucu = komut.ExecuteReader();
                    while (okutucu.Read())
                    {
                        hastaneAdi = okutucu.GetString(0);
                    }
                    baglanti.Close();

                    //Rapor veri tabanına kaydedildi
                    baglanti.Close();
                    baglanti.Open();
                    string komut2 = "INSERT INTO `sorunbildirim` (`tc`,`bildirimMetni`,`cozulduMu`,`cozumRaporu`,`hastaneAdi`) VALUES ('" + DoktorTC + "','" + sorunTXT.Text + "','Beklemede','Beklemede','"+hastaneAdi+"');";
                    MySqlCommand ekle = new MySqlCommand(komut2, baglanti);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Raporunuz başarı ile oluşturuldu, teknik ekip sorunu çözüp sizin ile iletişime geçecektir.", "Rapor Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sorunTXT.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 4x0003", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
