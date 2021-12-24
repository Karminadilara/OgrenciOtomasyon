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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }

        OgrenciIslemleri islemler = new OgrenciIslemleri();
        bool kaydetMi = true;

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = Convert.ToInt32(txtID.Text);
            ogrenci.Adi = txtOgrenciAdi.Text;
            ogrenci.Adres = txtAdres.Text;
            ogrenci.Bolum = txtBolum.Text;
            ogrenci.Soyad = txtOgrenciSoyadi.Text;

            

            if (kaydetMi)
            {
                if (!islemler.IdKontrol(ogrenci.Id))
                {
                    MessageBox.Show("ID Kayıtlı", "Id Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                bool sonuc = islemler.Kaydet(ogrenci);

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
                bool sonuc = islemler.Guncelle(ogrenci);
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


        private void Listele()
        {
            List<Ogrenci> liste = islemler.OgrenciListele();

            lvOgrenci.Items.Clear();

            foreach (var item in liste)
            {
                var satir = new ListViewItem(new string[] {item.Id.ToString(),item.Adi,item.Soyad,item.Bolum });

                lvOgrenci.Items.Add(satir);
            }
        }

        private void KontrolleriBosalt()
        {
            txtAdres.Clear();
            txtBolum.Clear();
            txtID.Clear();
            txtOgrenciAdi.Clear();
            txtOgrenciSoyadi.Clear();
            txtID.ReadOnly = false;
            kaydetMi = true;
            btnOgrenciKaydet.Text = "Öğrenci Kaydet";
            btnOgrenciSil.Visible = false;
        }

        private void lvOgrenci_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lvOgrenci.SelectedItems[0];

            Ogrenci ogrenci = new Ogrenci();

            ogrenci = islemler.OgrenciGetir(Convert.ToInt32(item.Text));

            txtAdres.Text = ogrenci.Adres;
            txtBolum.Text = ogrenci.Bolum;
            txtID.Text = ogrenci.Id.ToString();
            txtOgrenciAdi.Text = ogrenci.Adi;
            txtOgrenciSoyadi.Text = ogrenci.Soyad;

            txtID.ReadOnly = true;

            btnOgrenciKaydet.Text = "Öğrenci Güncelle";
            kaydetMi = false;
            btnOgrenciSil.Visible = true;
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci = islemler.OgrenciGetir(Convert.ToInt32(txtID.Text));

            bool sonuc = islemler.Sil(ogrenci);


            if(sonuc)
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
