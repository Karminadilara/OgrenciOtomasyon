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
    public partial class NotIslemleri : Form
    {
        public NotIslemleri()
        {
            InitializeComponent();
        }

        SinifIslemleri sinifIslemleri = new SinifIslemleri();
        DersIslemleri dersIslemleri = new DersIslemleri();
        OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();
        Business.NotIslemleri notIslemleriBus = new Business.NotIslemleri();

        private void SinifDoldur()
        {
            List<Sinif> sinifListesi = new List<Sinif>();
            sinifListesi.Add(new Sinif { Id = 0, Adi = "Seçiniz" });

            sinifListesi.AddRange(sinifIslemleri.Listele());

            cmbSinif.DataSource = sinifListesi;

            cmbSinif.DisplayMember = "Adi";
            cmbSinif.ValueMember = "Id";
                
                
        }

        private void DersDoldur(int sinifId)
        {
            List<Entity.Ders> dersListesi = dersIslemleri.DersListele();

            Sinif sinif = sinifIslemleri.SinifGetir(sinifId);

            List<Entity.Ders> sinifDersListesi = new List<Entity.Ders>();

            sinifDersListesi.Add(new Entity.Ders { Id=0,Adi="Seçiniz"});

            sinifDersListesi.AddRange(dersListesi.Where(x => x.Id == sinif.Ders.Id));

            cmbDers.DataSource =sinifDersListesi ;

            cmbDers.DisplayMember = "Adi";
            cmbDers.ValueMember = "Id";

            


        }

        private void OgrenciListele(int sinifId) 
        {
            List<Ogrenci> ogrenciListesi = sinifIslemleri.SinifGetir(sinifId).Ogrenciler;


            lvOgrenciler.Items.Clear();

            foreach (var item in ogrenciListesi)
            {
                var satir = new ListViewItem(new string[] { item.Id.ToString(), item.Adi+ " " + item.Soyad  });

                lvOgrenciler.Items.Add(satir);
            }
        }


        private void NotIslemleri_Load(object sender, EventArgs e)
        {
            SinifDoldur();
        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secili = cmbSinif.SelectedValue.ToString();
            int seciliId = 0;
            int.TryParse(secili, out seciliId);
            if (seciliId != 0)
            {
                DersDoldur(seciliId);
                OgrenciListele(seciliId);
            }
                
        }

        private void lvOgrenciler_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lvOgrenciler.SelectedItems[0];

            Ogrenci ogrenci = new Ogrenci();

            ogrenci = ogrenciIslemleri.OgrenciGetir(Convert.ToInt32(item.Text));

            txtOgrenciId.Text = ogrenci.Id.ToString();
            txtOgrenciAd.Text = ogrenci.Adi + " " +ogrenci.Soyad;

            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Not not = new Not();
            not.NotId = Convert.ToInt32(txtNotId.Text);
            not.DersId = Convert.ToInt32(cmbDers.SelectedValue.ToString());
            not.SınıfId = Convert.ToInt32(cmbSinif.SelectedValue.ToString());
            not.OgrenciId = Convert.ToInt32(txtOgrenciId.Text);
            not.Vize = Convert.ToDouble(txtVize.Text);
            not.Final = Convert.ToDouble(txtFinal.Text);

            bool sonuc = notIslemleriBus.Kaydet(not);

            if (sonuc)
                MessageBox.Show("Başarıyla Kaydedildi.");
            else
                MessageBox.Show("Bir hata oluştu.");
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            List<Not> notlar = notIslemleriBus.Listele(Convert.ToInt32(cmbSinif.SelectedValue), Convert.ToInt32(cmbDers.SelectedValue));


            lvNotListesi.Items.Clear();

            foreach (var item in notlar)
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci = ogrenciIslemleri.OgrenciGetir(item.OgrenciId);

                var satir = new ListViewItem(new string[] { ogrenci.Adi + " "+ogrenci.Soyad,item.Vize.ToString(),item.Final.ToString(),item.Ortalama.ToString()  });

                lvNotListesi.Items.Add(satir);

                var gecenKalanSatir= new ListViewItem(new string[] { ogrenci.Adi + " " + ogrenci.Soyad, item.Ortalama.ToString() });

                if (item.Ortalama >= 50)
                    lvGecen.Items.Add(gecenKalanSatir);
                else
                    lvKalan.Items.Add(gecenKalanSatir);


            }
        }
    }
}
