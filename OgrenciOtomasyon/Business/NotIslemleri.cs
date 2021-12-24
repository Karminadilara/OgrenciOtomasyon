using OgrenciOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Business
{
    public class NotIslemleri
    {
        public bool Kaydet (Not not)
        {
            try
            {
                Data.NotData.Notlar.Add(not);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Not> Listele(int sinifId,int dersId)
        {
            return Data.NotData.Notlar.Where(x => x.SınıfId == sinifId && x.DersId == dersId).ToList();
        }
    }
}
