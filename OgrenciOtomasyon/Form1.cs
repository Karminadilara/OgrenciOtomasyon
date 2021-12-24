using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciOtomasyon.Entity;
using OgrenciOtomasyon.Business;

namespace OgrenciOtomasyon
{
    public partial class frmGiris : Form
    {

        /*
         * Veritabanı işlemleri DAO
         * İşlemlerin yapıldı BLL
         * Model olduğu Entity
         * Arayaüz katmanı UI
         */

        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            kullanici.Sifre = txtSifre.Text;

            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();

            bool sonuc = kullaniciIslemleri.Giris(kullanici);

            if (sonuc)
            {
                MessageBox.Show("Giriş Başarılı");
              
                MenuEkrani frm = new MenuEkrani();
                frm.Show();
                

            }
            else
            {
                MessageBox.Show("Giriş Başarısız.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtSifre.Clear();
                txtSifre.Focus();

            }

        }
    }
}
