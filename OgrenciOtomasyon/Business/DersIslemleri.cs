using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Business
{
    public class DersIslemleri
    {
        public bool Kaydet(Entity.Ders ders)
        {
            try
            {
                Data.DersData.Dersler.Add(ders);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IdKontrol(int id)
        {
            Entity.Ders ders = Data.DersData.Dersler.Where(x => x.Id == id).SingleOrDefault();

            if (ders != null)
                return false;
            else
                return true;
        }

        public List<Entity.Ders> DersListele()
        {
            return Data.DersData.Dersler;
        }

        public Entity.Ders DersGetirIdyeGore(int id)
        {
            return Data.DersData.Dersler.Where(x => x.Id == id).SingleOrDefault();
        }

        public bool Sil(Entity.Ders ders)
        {
            try
            {
                Data.DersData.Dersler.Remove(ders);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Guncelle (Entity.Ders ders)
        {
            Entity.Ders dersGuncellenecek = Data.DersData.Dersler.Where(x => x.Id == ders.Id).FirstOrDefault();

            try
            {
                dersGuncellenecek.Adi = ders.Adi;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
