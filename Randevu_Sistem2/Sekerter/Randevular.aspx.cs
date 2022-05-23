using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2
{
    public partial class Randevular : System.Web.UI.Page
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fillData();
                
            }
        }
        private void fillData()
        {
            DateTime bugun = DateTime.Today;
            var adet = ent.Randevus.Where(x => (x.Randevu_date == bugun)).ToList();
            var doktorid = ent.Randevus.Select(q => q.Doktor_id).FirstOrDefault();
            var doktorAd = ent.Doktors.Where(q => q.Doktor_id == doktorid).ToString();
            var hastaid = ent.Randevus.Select(q => q.Hasta_id).FirstOrDefault();
            var hastaAd = ent.Hasta.Where(q => q.Hasta_id == hastaid).ToString();

            this.GridViewRandevularSekerter.DataSource = ent.Randevus.Where(q=> q.Randevu_date == bugun)
                .Join(ent.Hasta,
                r => r.Hasta_id,
                h => h.Hasta_id,
                (r, h) => new
                {
                    randevu = r,
                    hasta = h
                })
                .Join(ent.Doktors,
                rr => rr.randevu.Doktor_id,
                d => d.Doktor_id,
                (rr, d) => new {
                    randevuS = rr.randevu.Randevu_saati,
                    hastaA = rr.hasta.Hasta_ad,
                    doktorA = d.Doktor_ad,
                }).Select(x => new {                    
                    RS_VG = x.randevuS,
                    DoktorAdi_GV = x.doktorA,
                    HastaAdi_GV = x.hastaA
                }).ToList();  
            
            this.GridViewRandevularSekerter.DataBind();
            
        }
    }
}