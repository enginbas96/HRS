using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRS_Desktop
{
    public partial class GirisForm : Form
    {
        string KullaniciTC="", birim = "bos";        
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");
        public GirisForm()
        {
            InitializeComponent();
        }

        //Form -> Closing
        private void GirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        //Giriş Yap Butonu -> Click
        private void girisYapBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //Database hesap kontrolü
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM calisan WHERE tc = '" + kAdiTXT.Text + "' AND sifre ='" + sifreTXT.Text + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    birim = "calisan";
                    KullaniciTC = okutucu["tc"].ToString();
                    MessageBox.Show("Hoş geldiniz Sayın " + okutucu["ad"] + " " + okutucu["soyad"] + ", iyi çalışmalar diliyorum.");
                }
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut2 = new MySqlCommand("SELECT * FROM doktorlar WHERE tc ='" + kAdiTXT.Text + "' AND sifre ='" + sifreTXT.Text + "'", baglanti);
                MySqlDataReader okutucu2 = komut2.ExecuteReader();
                while (okutucu2.Read())
                {
                    birim = "doktor";
                    KullaniciTC = okutucu2["tc"].ToString();
                    MessageBox.Show("Hoş geldiniz Sayın " + okutucu2["adsoyad"] + ", iyi çalışmalar diliyorum.");
                }
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("SELECT * FROM admin WHERE kullaniciAdi ='" + kAdiTXT.Text + "' AND Sifre ='" + sifreTXT.Text + "'", baglanti);
                MySqlDataReader okutucu3 = komut3.ExecuteReader();
                while (okutucu3.Read())
                {
                    birim = "admin";
                    MessageBox.Show("Admin girişi onaylandı, iyi çalışmalar diliyorum.");
                }
                baglanti.Close();

                //Birim kontrolü ve yönlendirme
                if (birim == "doktor")
                {
                    DoktorGiris doktorGiris = new DoktorGiris(KullaniciTC);
                    doktorGiris.Show();
                }
                if (birim == "calisan")
                {
                    CalisanGirisForm calisanGiris = new CalisanGirisForm(KullaniciTC);
                    calisanGiris.Show();
                }
                if (birim == "admin")
                {
                    AdminGiris adminGiris = new AdminGiris();
                    adminGiris.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 9x9999", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Hesap bulunamadı
            if (birim == "bos")
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış girilmiştir. Lütfen doğru bir şekilde giriniz ve tekrar deneyiniz.");
            }
            else
            {
                this.Hide();
            }
        }

        //kAdiText -> TextChanged
        //Kullanıcı Adına yalnızca rakam girilmesine izin ver
        private void kAdiText_TextChanged(object sender, EventArgs e)
        {
            string kontrolText = kAdiTXT.Text;
            try
            {
                for (int i = 0; i < kontrolText.Length; i++)
                {
                    if (!char.IsDigit(kontrolText[i]))
                    {
                        kAdiTXT.Text = kAdiTXT.Text.Remove(i, 1);
                        kAdiTXT.SelectionStart = i;
                    }
                }
            }
            catch (Exception)
            {
            }            
        }
    }
}
