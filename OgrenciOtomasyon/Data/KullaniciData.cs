using OgrenciOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Data
{
    public static class KullaniciData
    {
       public static  List<Kullanici> Kullanicilar = new List<Kullanici> 
       { 
           new Kullanici{
               Id=1,
               KullaniciAdi="Test",
               Sifre="Test2"
           },
           new Kullanici{
               Id=2,
               KullaniciAdi="Test3",
               Sifre="Test4"
           },
           new Kullanici{
               Id=3,
               KullaniciAdi="Test4",
               Sifre="Test5"
           },
           new Kullanici{
               Id=4,
               KullaniciAdi="1",
               Sifre="1"
           }
       };
    }
}
