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
    public partial class DoktorRandevuIslemleri : Form
    {
        string DoktorTC;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");
        public DoktorRandevuIslemleri(string tc)
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

        //Çıkış Butonu -> Click
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form -> Closing
        private void DoktorRandevuIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Form -> Load
        private void DoktorRandevuIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                bool hastaVarMi = false;
                baglanti.Close();
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM randevular where doktorTC = '" + DoktorTC + "'", baglanti);
                MySqlDataReader okutucu = komut.ExecuteReader();
                while (okutucu.Read())
                {
                    hastaVarMi = true;
                }
                if (hastaVarMi == false)
                {
                }
                else
                {
                    randevuVerileriniCek();
                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 5x0001", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }       
        
        //Data grid view hücresine tıklanıldığında
        private void randevularDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string hastaTC, hastaAd, hastaSoyad, randevuTarihi, randevuSaati;
            try
            {
                if (randevularimDGV.SelectedRows.Count > 0)
                {
                    hastaTC = randevularimDGV.SelectedRows[0].Cells["Hasta TC"].Value.ToString();
                    hastaAd = randevularimDGV.SelectedRows[0].Cells["Hasta Ad"].Value.ToString();
                    hastaSoyad = randevularimDGV.SelectedRows[0].Cells["Hasta Soyad"].Value.ToString();
                    randevuTarihi = randevularimDGV.SelectedRows[0].Cells["Randevu Tarihi"].Value.ToString();
                    randevuSaati = randevularimDGV.SelectedRows[0].Cells["Randevu Saati"].Value.ToString();

                    hastaTcTXT.Text = hastaTC;
                    hastaAdSoyadTXT.Text = hastaAd + " " + hastaSoyad;
                    randevuTarihiTXT.Text  = randevuTarihi;
                    randevuSaatiText.Text = randevuSaati + ":00";                    
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir randevu seçip işleminizi tekrar ediniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 5x0002", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Randevuları Veritabanından çeken metod
        private void randevuVerileriniCek()
        {
            try
            {
                randevularimDGV.RowHeadersVisible = false;
                randevularimDGV.DataSource = null;
                randevularimDGV.Rows.Clear();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT h.tc AS 'Hasta TC', h.ad AS 'Hasta Ad', h.soyad AS 'Hasta Soyad', r.saat AS 'Randevu Saati', r.tarih AS 'Randevu Tarihi' FROM randevular r JOIN hasta h ON r.hastaTC = h.tc WHERE r.doktorTC ='" + DoktorTC + "'", baglanti);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Hasta TC");
                dataTable.Columns.Add("Hasta Ad");
                dataTable.Columns.Add("Hasta Soyad");
                dataTable.Columns.Add("Randevu Tarihi");
                dataTable.Columns.Add("Randevu Saati");

                baglanti.Close();
                baglanti.Open();
                dataAdapter.Fill(dataTable);
                randevularimDGV.DataSource = dataTable;
                randevularimDGV.Columns["Hasta TC"].Width = 130;
                randevularimDGV.Columns["Hasta Ad"].Width = 110;
                randevularimDGV.Columns["Hasta Soyad"].Width = 140;
                randevularimDGV.Columns["Randevu Tarihi"].Width = 100;
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen yetkililere bildiriniz. HATA KODU : 5x0003", "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
