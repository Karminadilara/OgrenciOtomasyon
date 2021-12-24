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
    public partial class OgrenciDersListesi : Form
    {
        public OgrenciDersListesi()
        {
            InitializeComponent();
        }

        int _sinifId = 0;
        Sinif sinif = new Sinif();
        SinifIslemleri sinifIslemleri = new SinifIslemleri();
        OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();
        DersIslemleri dersIslemleri = new DersIslemleri();
        List<Ogrenci> sinifOgrenciListesi = new List<Ogrenci>();
        List<Ogrenci> liste = new List<Ogrenci>();
        public OgrenciDersListesi(int sinifId)
        {
            InitializeComponent();
            _sinifId = sinifId;
            sinif = sinifIslemleri.SinifGetir(sinifId);
        }

        public void TumOgrencilerListele()
        {
            liste = ogrenciIslemleri.OgrenciListele();

            lvTumOgrenciler.Items.Clear();

            foreach (var item in sinifOgrenciListesi)
            {
                Ogrenci ogrenci = liste.Where(x => x.Id == item.Id).SingleOrDefault();

                liste.Remove(ogrenci);
            }
            
            foreach (var item in liste)
            {
                var satir = new ListViewItem(new string[] { item.Id.ToString(), item.Adi });

                lvTumOgrenciler.Items.Add(satir);
            }
        }

        public void SinifOgrencileriListele()
        {
            sinifOgrenciListesi = sinifIslemleri.SinifGetir(_sinifId).Ogrenciler;

            lvSinifOgrenciler.Items.Clear();


            foreach (var item in sinifOgrenciListesi)
            {
                var satir = new ListViewItem(new string[] { item.Id.ToString(), item.Adi });

                lvSinifOgrenciler.Items.Add(satir);
            }
        }

        private void OgrenciDersListesi_Load(object sender, EventArgs e)
        {
            SinifOgrencileriListele();
            TumOgrencilerListele();
            lblDersAdi.Text ="Ders Adı : "+ dersIslemleri.DersGetirIdyeGore(sinif.Ders.Id).Adi;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            var seciliOgrenciler = lvTumOgrenciler.SelectedItems;

            foreach (ListViewItem item in seciliOgrenciler)
            {
                
                int ogrenciId =Convert.ToInt32(item.SubItems[0].Text);


                Ogrenci ogrenci = liste.Where(x => x.Id == ogrenciId).FirstOrDefault();


                // Derse kayıtlı öğrencileri listeden çıkarmasaydık bu kontrole ihtiyaç vardı.
                /*
                Ogrenci ogrenciSinif = sinifOgrenciListesi.Where(x => x.Id == ogrenciId).SingleOrDefault();

                if(ogrenciSinif != null)
                {
                    MessageBox.Show("Öğrenci derse kayıtlı.");
                    return;
                }*/


                liste.Remove(ogrenci);

                sinifOgrenciListesi.Add(ogrenci);


                lvTumOgrenciler.Items.Remove(item);

                lvSinifOgrenciler.Items.Add(item);
                
            }
        }

        private void btnOgrenciCikar_Click(object sender, EventArgs e)
        {
            var seciliOgrenciler = lvSinifOgrenciler.SelectedItems;

            foreach (ListViewItem item in seciliOgrenciler)
            {
                int ogrenciId = Convert.ToInt32(item.SubItems[0].Text);

                Ogrenci ogrenci = sinifOgrenciListesi.Where(x => x.Id == ogrenciId).SingleOrDefault();

                sinifOgrenciListesi.Remove(ogrenci);

                liste.Add(ogrenci);

                lvSinifOgrenciler.Items.Remove(item);

                lvTumOgrenciler.Items.Add(item);
            }
        }
    }
}
