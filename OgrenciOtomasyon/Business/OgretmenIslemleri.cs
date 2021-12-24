using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Business
{
    public class OgretmenIslemleri
    {
        public bool Kaydet(Entity.Ogretmen ogretmen)
        {
            try
            {
                Data.OgretmenData.OgretmenListesi.Add(ogretmen);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


        }

        public bool IdKontrol(int id)
        {
            Entity.Ogretmen ogrenci = Data.OgretmenData.OgretmenListesi.Where(x => x.Id == id).FirstOrDefault();

            if (ogrenci != null)
                return false;
            else
                return true;
        }

        public List<Entity.Ogretmen> OgretmenListele()
        {
            return Data.OgretmenData.OgretmenListesi;
        }

        public Entity.Ogretmen OgretmenGetir(int id)
        {
            return Data.OgretmenData.OgretmenListesi.Where(x => x.Id == id).SingleOrDefault();
        }

        public bool Guncelle(Entity.Ogretmen ogretmen)
        {
            try
            {
                Entity.Ogretmen ogr = new Entity.Ogretmen();

                ogr = Data.OgretmenData.OgretmenListesi.Where(x => x.Id == ogretmen.Id).SingleOrDefault();

                ogr.Ad = ogretmen.Ad;
                ogr.Brans = ogretmen.Brans;
                ogr.Soyad = ogretmen.Soyad;

                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }

        public bool Sil(Entity.Ogretmen ogretmen)
        {
            return Data.OgretmenData.OgretmenListesi.Remove(ogretmen) ;
        }
    }
}
