using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabani;

namespace Siniflarim
{
    public class Sekreter
    {
        public VeriTabani.Sekreter Hesap_var_mi(string tc, string pass)
        {
            VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
            var sonuc = ent.Sekreters.Where(q => q.Sekreter_TC == tc && q.Sekreter_sifresi == pass);
            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else return null;
        }

    }
}
