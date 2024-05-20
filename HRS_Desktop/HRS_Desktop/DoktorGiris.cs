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
    public partial class DoktorGiris : Form
    {
        string DoktorTC;
        public DoktorGiris(string kullanici)
        {
            InitializeComponent();
            DoktorTC = kullanici;
        }

        //Geri Butonu -> Click
        private void geriBTN_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }

        //Yardım Butonu -> Click
        private void yardimBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("REÇETE İŞLEMLERİ butonuna basarak hastaların reçeteleri ile ilgili işlemlere erişebilirsiniz.\n \nRANDEVU İŞLEMLERİ butonuna tıklayarak kendi randevularınız ile ilgili işlemlere erişebilirsiniz.\n \nKULLANICI İŞLEMLERİ butonuna tıklayarak hesabınızın ayarlarını değiştirebilirsiniz.", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Çıkış Butonu -> Click
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form -> Closing
        private void DoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Reçete İşlemleri Butonu -> Click
        private void receteIslemleriBTN_Click(object sender, EventArgs e)
        {
            receteIslemleri receteIslemleri = new receteIslemleri(DoktorTC);
            receteIslemleri.Show();
            this.Hide();
        }

        //Kullanıcı İşlemleri -> Click
        private void kullaniciIslemleriBTN_Click(object sender, EventArgs e)
        {
            DoktorIslemleri doktorIslemleri = new DoktorIslemleri(DoktorTC);
            doktorIslemleri.Show();
            this.Hide();
        }

        //Randevu İşlemleri -> Click
        private void randevuIslemleriBTN_Click(object sender, EventArgs e)
        {
            DoktorRandevuIslemleri doktorRandevuIslemleri = new DoktorRandevuIslemleri(DoktorTC);
            doktorRandevuIslemleri.Show();
            this.Hide();
        }
    }
}
