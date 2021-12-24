using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Entity
{
    public class Sinif
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public Ders Ders { get; set; }
        public Ogretmen Ogretmen { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

    }
}
