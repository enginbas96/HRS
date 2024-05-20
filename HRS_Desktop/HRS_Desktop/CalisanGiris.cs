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
    public partial class CalisanGirisForm : Form
    {
        string CalisanTc;
        
        public CalisanGirisForm(string kullanici)
        {
            InitializeComponent();
            CalisanTc = kullanici;
        }

        //Geri Butonu -> Click
        private void geriBTN_Click(object sender, EventArgs e)
        {            
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }

        //Yardim Butonu -> Click
        private void yardimBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HASTA KAYIT butonuna basarak yeni hastalar kayıt edebilir,\n \nRANDEVU butonuna tıklayarak kayıtlı olan hasta üzerinde randevu oluşturabilir,\n \nKULLANICI İŞLEMLERİ butonuna tıklayarak hesabınızın ayarlarını değiştirebilirsiniz.", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Çıkış Butonu -> Click
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //Form -> Closing
        private void CalisanGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Hasta Kayit Butonu -> Click
        private void hastaKayitFormBTN_Click(object sender, EventArgs e)
        {
            HastaKayitForm hastaKayitForm = new HastaKayitForm(CalisanTc);
            hastaKayitForm.Show();
            this.Hide();
        }

        //Kullanici İşlemleri Butonu -> Click
        private void kullaniciIslemFormBTN_Click(object sender, EventArgs e)
        {
            CalisanIslemleri kullaniciIslemleriForm = new CalisanIslemleri(CalisanTc);
            kullaniciIslemleriForm.Show();
            this.Hide();
        }

        //Randevu İşlemleri Butonu -> Click
        private void randevuIslemFormBTN_Click(object sender, EventArgs e)
        {
                RandevuForm randevuForm = new RandevuForm(CalisanTc);
                randevuForm.Show();
                this.Hide();            
        }
    }
}
