using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgrenciOtomasyon.Entity;
using OgrenciOtomasyon.Data;

namespace OgrenciOtomasyon.Business
{
    public class KullaniciIslemleri
    {
        public bool Giris(Kullanici kullanici)
        {
            Kullanici k = Data.KullaniciData.Kullanicilar.Where(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre).FirstOrDefault();

            if (k != null)
                return true;
            else
                return false;
        }
    }
}
