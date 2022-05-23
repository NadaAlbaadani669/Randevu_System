using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Kullanci
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        public string Veriekleme(VeriTabani.Kullanci nesne)
        {
            VeriTabani.Kullanci yeni = new VeriTabani.Kullanci();
            yeni = nesne;
            ent.Kullanci.Add(yeni);
            int s = ent.SaveChanges();
            if (s == 1)
            {
                return "1";
            }
            else return "0";

        }
        public VeriTabani.Kullanci hesap_var_mi(string tc, string pass , string yetki)
        {
            var sonuc = ent.Kullanci.Where(q => q.Kullanci_TC == tc && q.Kullanci_sifresi == pass && q.Kullanci_Yetki == yetki);
            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else return null;
        }

        public List<VeriTabani.Kullanci> listele()
        {
            VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
            var sonuc = ent.Kullanci.ToList();
            return sonuc;
        }
        public string Sifre_goster(string tc, string email, string yetki)
        {

            var result = ent.Kullanci.Where(x => x.Kullanci_TC == tc && x.Kullanci_email == email && x.Kullanci_Yetki == yetki).Select(x => x.Kullanci_sifresi).FirstOrDefault();
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
