using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Data
{
    public static class DersData
    {
        public static List<Entity.Ders> Dersler = new List<Entity.Ders>
        {
            new Entity.Ders
            {
                Id=1,
                Adi="Yazılım"
            },
            new Entity.Ders
            {
                Id=2,
                Adi="SQL Eğitimi"
            },
            new Entity.Ders
            {
                Id=3,
                Adi="Web Yazılım"
            }
        };

    }
}
