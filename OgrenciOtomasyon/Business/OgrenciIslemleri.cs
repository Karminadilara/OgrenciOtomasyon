using OgrenciOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Business
{
    public class OgrenciIslemleri
    {
        public bool Kaydet(Ogrenci ogrenci)
        {
            try
            {
                Data.OgrenciData.OgrenciListesi.Add(ogrenci);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

            
        }

        public bool IdKontrol(int id)
        {
            Ogrenci ogrenci = Data.OgrenciData.OgrenciListesi.Where(x => x.Id == id).FirstOrDefault();

            if (ogrenci != null)
                return false;
            else
                return true;
        }

        public List<Ogrenci> OgrenciListele()
        {
            return Data.OgrenciData.OgrenciListesi;
        }

        public Ogrenci OgrenciGetir(int id)
        {
            return Data.OgrenciData.OgrenciListesi.Where(x => x.Id == id).SingleOrDefault();
        }

        public bool Guncelle (Ogrenci ogrenci)
        {
            try
            {
                Ogrenci ogr = new Ogrenci();

                ogr = Data.OgrenciData.OgrenciListesi.Where(x => x.Id == ogrenci.Id).SingleOrDefault();

                ogr.Adi = ogrenci.Adi;
                ogr.Adres = ogrenci.Adres;
                ogr.Bolum = ogrenci.Bolum;
                ogr.Soyad = ogrenci.Soyad;

                return true;
            }
            catch (Exception)
            {

                return false;
            }


            
        }

        public bool Sil(Ogrenci ogrenci)
        {
            return Data.OgrenciData.OgrenciListesi.Remove(ogrenci); ;
        }
    }
}
