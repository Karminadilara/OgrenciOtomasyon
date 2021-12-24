using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Data
{
    public class OgretmenData
    {
        public static List<Entity.Ogretmen> OgretmenListesi = new List<Entity.Ogretmen>
        {
            new Entity.Ogretmen {
                Ad="Ahmet",
                Soyad="Ahmets",
                Brans="Bilgisayar",
                Id=1
            },
            new Entity.Ogretmen {
                Ad="Ayşe",
                Soyad="Ayşes",
                Brans="Tarih",
                Id=2
            }
        };
    }
}
