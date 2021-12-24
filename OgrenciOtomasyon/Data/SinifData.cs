using OgrenciOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Data
{
    public static class SinifData
    {
        public static List<Sinif> Siniflar = new List<Sinif>
        {
            new Sinif
            {
                Id=1,
                Adi="C# Sınıfı",
                Ders= new Entity.Ders
                {
                   Id=1,
                   Adi="Yazılım"
                },
                Ogretmen=new Ogretmen
                {
                    Ad="Ahmet",
                    Soyad="Ahmets",
                    Brans="Bilgisayar",
                    Id=1

                },
                Ogrenciler =new List<Ogrenci>{
                    new Ogrenci {
                        Adi="Ahmet",
                        Soyad="Ahmets",
                        Bolum="Bilgisayar",
                        Adres="İstanbul",
                        Id=1
                    },
                    new Ogrenci {
                        Adi="Ayşe",
                        Soyad="Ayşes",
                        Bolum="Tarih",
                        Adres="Ankara",
                        Id=2
                    }
                }
            },

        };
    }
}
