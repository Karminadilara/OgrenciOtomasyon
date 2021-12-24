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
using OgrenciOtomasyon.Entity;

namespace OgrenciOtomasyon
{
    public partial class SinifForm : Form
    {
        public SinifForm()
        {
            InitializeComponent();
        }

        SinifIslemleri islemler = new SinifIslemleri();
        DersIslemleri dersIslemleri = new DersIslemleri();
        OgretmenIslemleri ogretmenIslemler = new OgretmenIslemleri();
        bool kaydetMi = true;

        public void Listele()
        {
            List<Sinif> liste = islemler.Listele();

            lvSinif.Items.Clear();

            foreach (var item in liste)
            {
                var satir = new ListViewItem(new string[] { item.Id.ToString(), item.Adi,item.Ogretmen.Ad,item.Ders.Adi });

                lvSinif.Items.Add(satir);
            }
        }
        public void DersleriDoldur()
        {
            List<Entity.Ders> dersListesi = new List<Entity.Ders>();
            dersListesi.Add(new Entity.Ders { Id = 0, Adi = "Seçiniz" });
            dersListesi.AddRange(dersIslemleri.DersListele());

            
            cmbDers.DataSource = dersListesi;
            cmbDers.DisplayMember = "Adi";
            cmbDers.ValueMember = "Id";

            cmbDers.SelectedValue = 0;
            
        }
        public void OgretmenDoldur()
        {
            List<Ogretmen> ogretmenListesi = new List<Ogretmen>();
            ogretmenListesi.Add(new Ogretmen { Id = 0, Ad = "Seçiniz" });
            ogretmenListesi.AddRange(ogretmenIslemler.OgretmenListele());

            cmbOgretmen.DataSource = ogretmenListesi;
            cmbOgretmen.DisplayMember = "Ad";
            cmbOgretmen.ValueMember = "Id";

            cmbOgretmen.SelectedValue = 0;

        }
        public void KontrolleriBosalt()
        {
            txtSinifAdi.Clear();
            txtId.Clear();
            txtId.ReadOnly = false;
            kaydetMi = true;
            btnKaydet.Text = "Sınıf Kaydet";
            btnSil.Visible = false;
            cmbDers.SelectedValue = 0;
            cmbOgretmen.SelectedValue = 0;
            btnOgrenci.Visible = false;
        }
        private void SinifForm_Load(object sender, EventArgs e)
        {
            Listele();
            DersleriDoldur();
            OgretmenDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Sinif sinif = new Sinif();
            sinif.Id = Convert.ToInt32(txtId.Text);
            sinif.Adi = txtSinifAdi.Text;


            if(Convert.ToInt32(cmbOgretmen.SelectedValue)==0 || Convert.ToInt32(cmbDers.SelectedValue) == 0)
            {
                MessageBox.Show("Lütfen alanları kontrol ediniz");
                return;
            }


            int ogretmenId = Convert.ToInt32(cmbOgretmen.SelectedValue);
            Ogretmen ogretmen = ogretmenIslemler.OgretmenGetir(ogretmenId);

            sinif.Ogretmen = ogretmen;

            sinif.Ders = dersIslemleri.DersGetirIdyeGore(Convert.ToInt32(cmbDers.SelectedValue));


            if (kaydetMi)
            {
                bool sonuc = islemler.Kaydet(sinif);

                if (sonuc)
                    MessageBox.Show("Başarıyla Kaydedildi");
                else
                    MessageBox.Show("Kaydedilirken bir hata oluştu");
            }
            else
            {
                bool gSonuc = islemler.Guncelle(sinif);

                if (gSonuc)
                    MessageBox.Show("Başarıyla Güncellendi.");
                else
                    MessageBox.Show("Güncellenirken Bir Hata Oluştu");
            }



            KontrolleriBosalt();
            Listele();
           

        }

        private void lvSinif_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lvSinif.SelectedItems[0];

            Sinif sinif = new Sinif();

            sinif = islemler.SinifGetir(Convert.ToInt32(item.Text));

            txtId.Text = sinif.Id.ToString();
            txtSinifAdi.Text = sinif.Adi;
            cmbDers.SelectedValue = sinif.Ders.Id;
            cmbOgretmen.SelectedValue = sinif.Ogretmen.Id;

            txtId.ReadOnly = true;

            btnKaydet.Text = "Sınıf Güncelle";
            kaydetMi = false;
            btnSil.Visible = true;
            btnOgrenci.Visible = true;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sinif sinif = islemler.SinifGetir(Convert.ToInt32(txtId.Text));

            bool sonuc = islemler.Sil(sinif);

            if (sonuc)
                MessageBox.Show("Başarıyla Silindi");
            else
                MessageBox.Show("Silinirken Bir Hata Oluştu");


            KontrolleriBosalt();
            Listele();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciDersListesi frmList = new OgrenciDersListesi(Convert.ToInt32(txtId.Text));
            frmList.Show();
        }
    }
}
