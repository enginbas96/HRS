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
    public partial class HastaKayitForm : Form
    {
        bool kontrol = false;
        string tc;
        string cinsiyet = "bos";
        string defaultSifre = "123";
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");

        public HastaKayitForm(string kullanici)
        {
            InitializeComponent();
            tc = kullanici;
        }      
        
        //Geri Butonu -> Click
        private void geriBTN_Click(object sender, EventArgs e)
        {
            CalisanGirisForm calisanGiris = new CalisanGirisForm(tc);
            calisanGiris.Show();
            this.Hide();
        }

        //Form -> Closing
        private void HastaKayitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Hastaı Kaydet Butonu -> Click
        private void hastayiKaydetBTN_Click(object sender, EventArgs e)
        {
            if (hastaTcNoTXT.Text.Length <= 10)
            {
                MessageBox.Show("TC kimlik numarasını eksik girdiniz lütfen 11 haneli olarak giriniz.", "Kimlik Numarası Eksik Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (hastaDogumYiliTXT.Text.Length <= 3)
            {
                MessageBox.Show("Doğum yılını eksik girdiniz lütfen 4 haneli olarak giriniz.", "Doğum Yılı Eksik Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cinsiyetBelirle();
            bosKontrol();

            bool hastaVarMi = false;
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
                if (hastaVarMi == true)
                {
                    MessageBox.Show("Bu TC kimlik numarasına ait bir kayıt zaten mevcut lütfen bilgileri kontrol edip tekrar deneyin.", "Kayıt mevcut.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 0x0001", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (kontrol == true && hastaVarMi == false)
            {
                defaultSifre = hastaTcNoTXT.Text;
                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    string kayitKomut = "INSERT INTO `hasta` (`tc`, `password`, `ad`, `soyad`, `eposta`, `dogumyili`, `cinsiyet`) VALUES ('" + hastaTcNoTXT.Text + "','" + defaultSifre + "','" + hastaAdTXT.Text + "','" + hastaSoyadTXT.Text + "','" + hastaMailTXT.Text + "','" + hastaDogumYiliTXT.Text + "','" + cinsiyet + "');";
                    MySqlCommand ekle = new MySqlCommand(kayitKomut, baglanti);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Hasta kayıt işlemi başarı ile gerçekleşmiştir.", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 0x0002", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                temizle();
            }
        }

        /*   METOTLAR ------------------------------------------------------------------------------------------------------ */

        //Boşluk Kontrol Metodu
        private void bosKontrol()
        {
            if (hastaTcNoTXT.Text == "" || hastaAdTXT.Text == "" || hastaSoyadTXT.Text == "" || hastaMailTXT.Text == "" || hastaDogumYiliTXT.Text == "" || cinsiyet == "bos")
            {
                MessageBox.Show("Lütfen hastanın bilgilerini forma eksiksiz bir şekilde giriniz.", "Lütfen boş alanları doldurunuz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kontrol = false;
            }
            else
            {
                kontrol = true;
            }
        }

        //Cinsiyet Seçim Metodu
        private void cinsiyetBelirle()
        {
            if (erkekRBTN.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            if (kadinRBN.Checked == true)
            {
                cinsiyet = "Kadın";
            }
        }

        //Tüm elemanları temizleme metodu
        private void temizle()
        {
            hastaTcNoTXT.Clear();
            hastaAdTXT.Clear();
            hastaSoyadTXT.Clear();
            hastaMailTXT.Clear();
            hastaDogumYiliTXT.Clear();
            erkekRBTN.Checked = false;
            kadinRBN.Checked = false;
            cinsiyet = "bos";
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

        // AdText'e sadece harf girilebilecek ve baş harfi büyük başlayacak
        private void hastaAdTXT_TextChanged(object sender, EventArgs e)
        {
            string kontrolText = hastaAdTXT.Text;
            StringBuilder temizlenmisMetin = new StringBuilder();
            bool ilkHarf = true;
            for (int i = 0; i < kontrolText.Length; i++)
            {
                if (char.IsLetter(kontrolText[i]))
                {
                    if (ilkHarf)
                    {
                        temizlenmisMetin.Append(char.ToUpper(kontrolText[i]));
                        ilkHarf = false;
                    }
                    else
                    {
                        temizlenmisMetin.Append(char.ToLower(kontrolText[i]));
                    }
                }
            }
            hastaAdTXT.Text = temizlenmisMetin.ToString();
            hastaAdTXT.SelectionStart = hastaAdTXT.Text.Length;
        }

        //soyadText'e sadece harf girilebilecek ve baş harfi büyük başlayacak
        private void hastaSoyadTXT_TextChanged(object sender, EventArgs e)
        {
            string kontrolText = hastaSoyadTXT.Text;
            StringBuilder temizlenmisMetin = new StringBuilder();
            bool ilkHarf = true;
            for (int i = 0; i < kontrolText.Length; i++)
            {
                if (char.IsLetter(kontrolText[i]))
                {
                    if (ilkHarf)
                    {
                        temizlenmisMetin.Append(char.ToUpper(kontrolText[i]));
                        ilkHarf = false;
                    }
                    else
                    {
                        temizlenmisMetin.Append(char.ToLower(kontrolText[i]));
                    }
                }
            }
            hastaSoyadTXT.Text = temizlenmisMetin.ToString();
            hastaSoyadTXT.SelectionStart = hastaSoyadTXT.Text.Length;

        }

        //Dogum Yili rakamdan başka karakter girilemez
        private void hastaDogumYiliTXT_TextChanged(object sender, EventArgs e)
        {
            string kontrolText = hastaDogumYiliTXT.Text;
            try
            {
                for (int i = 0; i < kontrolText.Length; i++)
                {
                    if (!char.IsDigit(kontrolText[i]))
                    {
                        hastaDogumYiliTXT.Text = hastaDogumYiliTXT.Text.Remove(i, 1);
                        hastaDogumYiliTXT.SelectionStart = i;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
