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
    public partial class receteIslemleri : Form
    {
        string DoktorTC,hastaTC;
        string ilacAd, receteNo, receteTarihi, receteAciklama;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");
        public receteIslemleri(string tc)
        {
            InitializeComponent();
            DoktorTC = tc;
        }

        //Geri Butonu -> Click
        private void geriBTN_Click(object sender, EventArgs e)
        {
            DoktorGiris doktorGiris = new DoktorGiris(DoktorTC);
            doktorGiris.Show();
            this.Hide();
        }

        //Yardim Butonu -> Click
        private void yardimBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanın TC kimlik numarasını yazıp sorguladığınızda kullandığı ilaçlar, ilaç notları ve yazılış tarihleri ile birlikte listelenecektir. \n\nİlaç Ekle bölümünden yazmak istediğiniz ilacı seçip, ilacın kullanım sıklığı vb. notları ile birlikte bilgileri girip hastanın reçetesine işleyebilirsiniz.\n\nKullanılan ilaçlar listesinden ilacı üstüne tıklayıp dilerseniz ilacı kaldırabilirsiniz.", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Çıkış Butonu -> Click
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form -> Closing
        private void receteIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Form -> Load
        private void receteIslemleri_Load(object sender, EventArgs e)
        {
            ilacAdCB.Items.Clear();
            hastaTcNoTXT.Focus();
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM ilaclar", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    ilacAdCB.Items.Add(okutucu["ilacAd"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 3x0001", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Hasta Sorgula Butonu -> Click
        private void sorgulaBTN_Click(object sender, EventArgs e)
        {
            hastaTC = hastaTcNoTXT.Text;
            try
            {
                //Arayüzdeki tüm veriler temizlendi
                hastaAdTXT.Clear();
                hastaSoyadTXT.Clear();
                hastaDogumYiliTXT.Clear();
                receteNoTXT.Clear();
                aciklamaTXT.Clear();
                ilacAdCB.SelectedIndex = -1;
                ilacAdCB.Enabled = false;
                aciklamaTXT.Enabled = false;
                onaylaBTN.Enabled = false;
                randomBTN.Enabled = false;

                //Veritabanından verileri çeker
                ilacVerileriniCek();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 3x0002", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //ilacAdCB -> Changed
        private void ilacAdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            aciklamaTXT.Enabled = true;
            aciklamaTXT.Clear();
        }

        //Random Butonu -> Click
        //Random 6 karakterli bir kod üretmeye yarar
        private void randomBTN_Click(object sender, EventArgs e)
        {
            ilacAdCB.Enabled = true;
            onaylaBTN.Enabled = true;

            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int uzunluk = 6;

            Random rastgele = new Random();            
            StringBuilder rastgeleString = new StringBuilder();

            for (int i = 0; i < uzunluk; i++)
            {
                int index = rastgele.Next(karakterler.Length);
                rastgeleString.Append(karakterler[index]);
            }
            receteNoTXT.Text = rastgeleString.ToString();
            randomBTN.Enabled = false;
        }

        // Onayla Butonu -> Click
        private void onaylaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string verilisTarihi = DateTime.Now.Date.ToString("d");
                string receteKodu = receteNoTXT.Text;
                string ilacAdi = ilacAdCB.Text;
                string aciklama = aciklamaTXT.Text;
                if (ilacAdi == "" || receteKodu == "" || aciklamaTXT.Text.Length < 10)
                {
                    MessageBox.Show("Lütfen ilaç bilgilerini kontrol ediniz ve tekrar onaylayınız.", "Hasta Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    baglanti.Close();
                    baglanti.Open();
                    string kayitKomut = "INSERT INTO `receteler` (`hastaTC`, `doktorTC`, `ilaclar`, `aciklama`, `tarih`, `receteKodu`) VALUES ('" + hastaTC + "','" + DoktorTC + "','" + ilacAdi + "','" + aciklama + "','" + verilisTarihi + "','" + receteKodu + "');";
                    MySqlCommand ekle = new MySqlCommand(kayitKomut, baglanti);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    ilacVerileriniCek();

                    randomBTN.Enabled = false;
                    MessageBox.Show("İlaç başarıyla eklenmiştir.", "İlaç Eklenmiştir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 3x0003", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        //Datagridview'da bir hücreye tıklanıldığında satır hakkında bilgiler verilir
        private void ilaclarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                if (ilaclarDGV.SelectedRows.Count > 0)
                {
                    ilacAd = ilaclarDGV.SelectedRows[0].Cells["İlaç"].Value.ToString();
                    receteNo = ilaclarDGV.SelectedRows[0].Cells["Reçete Kodu"].Value.ToString();
                    receteTarihi = ilaclarDGV.SelectedRows[0].Cells["Veriliş Tarihi"].Value.ToString();
                    receteAciklama = ilaclarDGV.SelectedRows[0].Cells["Reçete Kodu"].Value.ToString();
                    MessageBox.Show("Seçtiğiniz ilaç hakkında; \n\nİlaç Adı : " + ilacAd + "\nAçıklama : " + receteAciklama + "\nVeriliş Tarihi : " + receteTarihi + "\nReçete Kodu : " + receteNo);
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir randevu seçip işleminizi tekrar ediniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 3x0004", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }
        
        //İlacı Kaldır Butonu -> Click
        private void ilacKaldirBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (ilacAd != "") 
                {
                    baglanti.Close();
                    baglanti.Open();
                    string silKomut = ("DELETE FROM receteler WHERE ilaclar = '" + ilacAd + "' AND receteKodu = '"+ receteNo +"';");
                    MySqlCommand sil = new MySqlCommand(silKomut, baglanti);
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    ilacVerileriniCek();
                    ilacAd = "";
                }
                else 
                {
                    MessageBox.Show("Lütfen listeden ilgili ilacı seçiniz ve ardından ilacı kaldır butonuna basınız.", "İlaç Seçilmemiş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 3x0005", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }


        /*   METOTLAR ------------------------------------------------------------------------------------------------------ */

        //Hasta var ise hastaya ait verileri çekeme metodu
        private void ilacVerileriniCek() 
        {
            ilaclarDGV.RowHeadersVisible = false;
            ilaclarDGV.DataSource = null;
            ilaclarDGV.Rows.Clear();

            try
            {
                bool hastaVarMi = false;
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM hasta where tc = '"+hastaTcNoTXT.Text+"'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    hastaVarMi = true;
                    hastaAdTXT.Text = okutucu["ad"].ToString();
                    hastaSoyadTXT.Text = okutucu["soyad"].ToString();
                    hastaDogumYiliTXT.Text = okutucu["dogumyili"].ToString();
                }
                baglanti.Close();

                if (hastaVarMi == true) 
                {                    
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT ilaclar AS 'ilaç', aciklama AS 'Açıklama', tarih AS 'Veriliş Tarihi', receteKodu AS 'Reçete Kodu' FROM receteler where hastaTC ='"+hastaTcNoTXT.Text+"'", baglanti);
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("İlaç");
                    dataTable.Columns.Add("Açıklama");
                    dataTable.Columns.Add("Veriliş Tarihi");
                    dataTable.Columns.Add("Reçete Kodu");

                    baglanti.Close();
                    baglanti.Open();
                    dataAdapter.Fill(dataTable);
                    ilaclarDGV.DataSource = dataTable;
                    baglanti.Close();

                    randomBTN.Enabled = true;
                }
                else
                {                    
                    MessageBox.Show("Girilen TC kimlik numarasına ait bir hasta bulunamadı, lütfen kontrol edip tekrar sorgulatınız.", "Hasta Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 3x0006", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*   KISITLAR ------------------------------------------------------------------------------------------------------ */

        //TC Rakamdan başka karakter girilemez
        private void hastaTcTXT_TextChanged(object sender, EventArgs e)
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
