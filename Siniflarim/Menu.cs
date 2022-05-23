using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Menu
    {
        public List<VeriTabani.Menu> GetByYetki(string yetki)
        {
            VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
            var sonuc = ent.Menus.Where(q => q.Menu_yetki.Contains(yetki)).OrderBy(q=> q.Menu_sira).ToList();
            return sonuc;
        }
    }
}
