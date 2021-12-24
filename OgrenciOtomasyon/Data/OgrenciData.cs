using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgrenciOtomasyon.Entity;

namespace OgrenciOtomasyon.Data
{
    public static class OgrenciData
    {
        public static List<Ogrenci> OgrenciListesi = new List<Ogrenci> 
        { 
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
            ,
            new Ogrenci {
                Adi="Fatma",
                Soyad="Fatmas",
                Bolum="Tarih",
                Adres="Ankara",
                Id=3
            }
        };
    }
}
