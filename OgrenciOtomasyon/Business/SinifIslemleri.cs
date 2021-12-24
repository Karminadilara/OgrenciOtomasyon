using OgrenciOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Business
{
    public class SinifIslemleri
    {
        public List<Sinif> Listele()
        {
            return Data.SinifData.Siniflar;
        }

        public bool Kaydet(Sinif sinif)
        {
            try
            {
                Data.SinifData.Siniflar.Add(sinif);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Sil(Sinif sinif)
        {
            Sinif silinecekSinif = Data.SinifData.Siniflar.Where(x => x.Id == sinif.Id).FirstOrDefault();

            if (silinecekSinif != null)
            {
                Data.SinifData.Siniflar.Remove(silinecekSinif);
                return true;
            }
            else
                return false;

        }

        public bool Guncelle(Sinif sinif)
        {
            Sinif guncellenecek = Data.SinifData.Siniflar.Where(x => x.Id == sinif.Id).SingleOrDefault();

            if (guncellenecek != null)
            {
                guncellenecek.Adi = sinif.Adi;
                guncellenecek.Ders = sinif.Ders;
                guncellenecek.Ogrenciler = sinif.Ogrenciler;
                guncellenecek.Ogretmen = sinif.Ogretmen;

                return true;
            }
            else
                return false;
        }

        public bool OgrenciKaydet(Ogrenci ogrenci,Sinif sinif)
        {
            Sinif eklenecek = Data.SinifData.Siniflar.Where(x => x.Id == sinif.Id).SingleOrDefault();

            try
            {
                eklenecek.Ogrenciler.Add(ogrenci);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Sinif SinifGetir(int id)
        {
            return Data.SinifData.Siniflar.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
