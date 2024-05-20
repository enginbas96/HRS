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
    public partial class SorunlarForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastanerandevu;User ID=root;Password=;");
        public SorunlarForm()
        {
            InitializeComponent();
        }

        //Geri Butonu -> Click
        private void geriBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Form -> Closing
        private void SorunlarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        //Sorun Durum CB -> Changed
        private void sorunDurumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            verileriCek();
        }

        //Sorunlar DGV -> Click
        private void sorunlarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sorunlarDGV.SelectedRows.Count > 0)
            {
                sorunBildirenTcTXT.Text = sorunlarDGV.SelectedRows[0].Cells["Bildiren TC"].Value.ToString();
                sorunAciklamaTXT.Text = sorunlarDGV.SelectedRows[0].Cells["Sorunun Açıklaması"].Value.ToString();
                sorunDurum2CB.Text = sorunlarDGV.SelectedRows[0].Cells["Sorunun Durumu"].Value.ToString();
                cozumRaporTXT.Text = sorunlarDGV.SelectedRows[0].Cells["Çözüm Raporu"].Value.ToString();
                hastaneTXT.Text = sorunlarDGV.SelectedRows[0].Cells["Hastane"].Value.ToString();
                sorunDurum2CB.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir randevu seçip işleminizi tekrar ediniz.");
            }
        }

        //Sorun Durum 2 CB -> Changed
        private void sorunDurum2CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sorunDurum2CB.Text == "Beklemede")
            {
                cozumRaporTXT.ReadOnly = true;
                guncelleBTN.Enabled = false;
            }
            else if (sorunDurum2CB.Text == "Çözüldü")
            {
                cozumRaporTXT.ReadOnly = false;
                guncelleBTN.Enabled = true;
            }
            else if (sorunDurum2CB.Text == "Çözülemedi")
            {
                cozumRaporTXT.ReadOnly = false;
                guncelleBTN.Enabled = true;
            }
        }

        //Güncelle Butonu -> Click
        private void guncelleBTN_Click(object sender, EventArgs e)
        {
            if (sorunDurum2CB.Text == "Beklemede")
            {
                MessageBox.Show("Bir sorun tekrar beklemeye alınamaz, çözüldü veya çözülemedi olarak işaretleyiniz.", "Sorunlar beklemeye alınamaz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cozumRaporTXT.Text.Length <= 10)
            {
                MessageBox.Show("Çözüm raporu 10 karakterden küçük olamaz.", "Yetersiz raporlama.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("UPDATE sorunbildirim SET cozulduMu='"+sorunDurum2CB.Text+"', cozumRaporu ='"+cozumRaporTXT.Text+"' WHERE bildirimMetni ='"+sorunAciklamaTXT.Text+"' AND tc ='"+sorunBildirenTcTXT.Text+"'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Temizle();
                    verileriCek();
                    guncelleBTN.Enabled=false;
                    sorunDurum2CB.Enabled = false;
                    sorunDurum2CB.SelectedIndex = -1;
                    cozumRaporTXT.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Güncelleme yapılırken bir hata ile karşılaşıldı.", "Güncelleme hatası.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        /*   METOTLAR ------------------------------------------------------------------------------------------------------ */

        //Verileri Çek Metodu
        private void verileriCek()
        {
            Temizle();
            try
            {
                sorunlarDGV.RowHeadersVisible = false;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT tc AS 'Bildiren TC', bildirimMetni AS 'Sorunun Açıklaması', cozulduMu AS 'Sorunun Durumu', cozumRaporu AS 'Çözüm Raporu', hastaneAdi AS Hastane FROM sorunbildirim WHERE cozulduMu = '" + sorunDurumCB.Text+"'", baglanti);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Bildiren TC");
                dataTable.Columns.Add("Sorunun Açıklaması");
                dataTable.Columns.Add("Sorunun Durumu");
                dataTable.Columns.Add("Çözüm Raporu");
                dataTable.Columns.Add("Hastane");
                baglanti.Close();
                baglanti.Open();
                dataAdapter.Fill(dataTable);
                sorunlarDGV.DataSource = dataTable;
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Verileri çekerken bir hata oluştu.", "Veriler çekilemedi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }    

        //Tüm Verileri Temizleme Metodu
        private void Temizle() 
        {
            sorunBildirenTcTXT.Clear();
            sorunAciklamaTXT.Clear();
            hastaneTXT.Clear();
            sorunDurum2CB.SelectedIndex = -1;
            cozumRaporTXT.Clear();
        }
    }
}
