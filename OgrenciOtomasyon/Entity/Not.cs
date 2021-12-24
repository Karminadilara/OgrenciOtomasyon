using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Entity
{
    public class Not
    {
        public int NotId { get; set; }
        public double Vize { get; set; }
        public double Final { get; set; }
        public int DersId { get; set; }
        public int SınıfId { get; set; }
        public int OgrenciId { get; set; }
        public double Ortalama 
        {   get
            {
                return (Vize * 0.4) + (Final * 0.6);
            }
        }

    }
}
