using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabani;



namespace Siniflarim
{
    public class Doktor
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        public VeriTabani.Doktor Hesap_var_mi(string tc, string pass)
        {
            var sonuc = ent.Doktors.Where(q => q.Doktor_TC == tc && q.Doktor_sifresi == pass);
            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else return null;
        }

        public List<VeriTabani.Randevu> randevuGet(string doktor_Ad)
        {
            DateTime bugun = DateTime.Today;
            var doktorID = ent.Doktors.Where(y => (y.Doktor_ad == doktor_Ad)).Select(y => y.Doktor_id).First();
            var sonuc = ent.Randevus.Where(x => (x.Randevu_date == bugun) && (x.Doktor_id == doktorID)).ToList();
            return sonuc;
        }

        public string TashisEkle(VeriTabani.Hasta_durumu nesne)
        {
            VeriTabani.Hasta_durumu yeni = new VeriTabani.Hasta_durumu();
            yeni = nesne;
            ent.Hasta_durumu.Add(yeni);
            var sonuc = ent.SaveChanges();
            if (sonuc == 1)
                return "1";
            else return "0";
        }
       
    }
}


