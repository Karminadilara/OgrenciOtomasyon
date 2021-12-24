using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciOtomasyon.Business;


namespace OgrenciOtomasyon
{
    public partial class frmOgretmen : Form
    {
        public frmOgretmen()
        {
            InitializeComponent();
        }

        OgretmenIslemleri islemler = new OgretmenIslemleri();
        bool kaydetMi = true;

        private void Listele()
        {
            List<Entity.Ogretmen> liste = islemler.OgretmenListele();

            lvOgretmen.Items.Clear();

            foreach (var item in liste)
            {
                var satir = new ListViewItem(new string[] { item.Id.ToString(), item.Ad, item.Soyad, item.Brans });

                lvOgretmen.Items.Add(satir);
            }
        }

        private void KontrolleriBosalt()
        {
            txtAd.Clear();
            txtBrans.Clear();
            txtId.Clear();
            txtSoyad.Clear();
            txtId.ReadOnly = false;
            kaydetMi = true;
            btnKaydet.Text = "Öğretmen Kaydet";
            btnSil.Visible = false;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Entity.Ogretmen ogretmen = new Entity.Ogretmen();
            ogretmen.Id = Convert.ToInt32(txtId.Text);
            ogretmen.Ad = txtAd.Text;
            ogretmen.Brans = txtBrans.Text;
            ogretmen.Soyad = txtSoyad.Text;



            if (kaydetMi)
            {
                if (!islemler.IdKontrol(ogretmen.Id))
                {
                    MessageBox.Show("ID Kayıtlı", "Id Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                bool sonuc = islemler.Kaydet(ogretmen);

                if (sonuc)
                {
                    MessageBox.Show("Başarıyla Kaydedildi");
                    Listele();
                    KontrolleriBosalt();
                }
                else
                {
                    MessageBox.Show("Kaydedilirken bir hata oluştu.");
                    KontrolleriBosalt();
                }
            }
            else
            {
                bool sonuc = islemler.Guncelle(ogretmen);
                if (sonuc)
                {
                    MessageBox.Show("Başarıyla Güncellendi.");
                    Listele();
                    KontrolleriBosalt();
                }
                else
                {
                    MessageBox.Show("Güncellenirken bir hata oluştu.");
                    KontrolleriBosalt();
                }

            }
        }

        private void frmOgretmen_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void lvOgretmen_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lvOgretmen_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lvOgretmen.SelectedItems[0];

            Entity.Ogretmen ogretmen = new Entity.Ogretmen();

            ogretmen = islemler.OgretmenGetir(Convert.ToInt32(item.Text));

            txtBrans.Text = ogretmen.Brans;
            txtId.Text = ogretmen.Id.ToString();
            txtAd.Text = ogretmen.Ad;
            txtSoyad.Text = ogretmen.Soyad;

            txtId.ReadOnly = true;

            btnKaydet.Text = "Öğrenci Güncelle";
            kaydetMi = false;
            btnSil.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Entity.Ogretmen ogretmen = new Entity.Ogretmen();
            ogretmen = islemler.OgretmenGetir(Convert.ToInt32(txtId.Text));

            bool sonuc = islemler.Sil(ogretmen);


            if (sonuc)
            {
                MessageBox.Show("Başarıyla Silindi");
                Listele();
                KontrolleriBosalt();
            }
            else
            {
                MessageBox.Show("Silinme işlemi sırasında bir hata oldu.");
                Listele();
                KontrolleriBosalt();
            }
        }
    }
}
