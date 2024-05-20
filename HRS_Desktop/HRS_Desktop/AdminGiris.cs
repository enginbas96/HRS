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
    public partial class AdminGiris : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");
        public AdminGiris()
        {
            InitializeComponent();
        }

        //Form -> Closing
        private void AdminGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Form -> Load
        private void AdminGiris_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SHOW TABLES", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    tablolarCB.Items.Add(okutucu["Tables_in_hastanerandevu"].ToString());
                }
                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Tablo isimlerini veritabanından çekme sırasında hata oluştu.", "Beklenmedik bir hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //tablolarCB -> Changed
        private void tablolarCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            verileriCek();
        }  

        //Sorguyu Gönder Butonu -> Click
        private void sorguGonderBTN_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                string sorguCumlesi = komutTXT.Text;
                MySqlCommand komut = new MySqlCommand(sorguCumlesi, baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Başarılı");
                verileriCek();
            }
            catch (Exception)
            {
                MessageBox.Show("Girilen sorguda veya bağlantıda bir hata ile karşılaşıldı lütfen gerekli kontrolleri sağlayıp tekrar deneyiniz.", "Beklenmedik bir hata!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }            
        }

        //Sorunlar Ekranına Git -> Click
        private void sorunlarEkraninaGitBTN_Click(object sender, EventArgs e)
        {
            SorunlarForm sorunlarForm = new SorunlarForm();
            sorunlarForm.Show();
        }

        /*   METOTLAR ------------------------------------------------------------------------------------------------------ */
        
        //Verileri Çek Metodu
        private void verileriCek()
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM " + tablolarCB.Text, baglanti);
                DataTable dataTable = new DataTable();
                baglanti.Close();
                baglanti.Open();
                dataAdapter.Fill(dataTable);
                veriTabaniDGV.DataSource = dataTable;
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Verileri çekerken bir hata oluştu.", "Veriler çekilemedi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
