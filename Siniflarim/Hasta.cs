using System.Collections.Generic;
using System.Linq;

namespace Siniflarim
{
    public class Hasta
    {
        public int HastaId { get; set; }
        public string HastaAdi { get; set; }

        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        public string Veriekleme(VeriTabani.Hasta nesne)
        {
            VeriTabani.Hasta yeni = new VeriTabani.Hasta();
            yeni = nesne;
            ent.Hasta.Add(yeni);
            int s = ent.SaveChanges();
            if (s == 1)
            {
                return "1";
            }
            else return "0";            

        }

        public string RandevuEkleme (VeriTabani.Randevu nesne)
        {
            VeriTabani.Randevu yeni = new VeriTabani.Randevu();
            yeni = nesne;
            ent.Randevus.Add(yeni);
            int sonuc = ent.SaveChanges();
            if (sonuc == 1)
                return "1";
            else return "0";
        }

        public string VeriGuncelle(string tc , VeriTabani.Hasta nesne)
        {
            VeriTabani.Hasta yeni = new VeriTabani.Hasta();
            var aranan = ent.Hasta.Where(a => a.Hasta_TC == tc).ToList().FirstOrDefault();
            aranan = nesne;
            ent.SaveChanges();
            return "1";
        }

        public string VeriSilme (string tc , VeriTabani.Hasta nesne)
        {
            VeriTabani.Hasta yeni = new VeriTabani.Hasta();
            var aranan = ent.Hasta.Where(s => s.Hasta_TC == tc).FirstOrDefault();
            ent.Hasta.Remove(yeni);
            ent.SaveChanges();

            return "1";
        }

        
        public VeriTabani.Hasta Hesap_var_mi(string tc , string pass , string yetki)
        {
            
            var sonuc = ent.Hasta.Where(q => q.Hasta_TC == tc && q.Hasta_sifresi == pass);
            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else return null;
        }

        public string Sifre_goster(string tc, string email)
        {
            
            var result = ent.Kullanci.Where(x => x.Kullanci_TC == tc && x.Kullanci_email == email).Select(x=> x.Kullanci_sifresi).FirstOrDefault();
            if (result != null)
            {
                
                return result;
            }
            else
            {
                return null;
            }
        }
      
    }
}
