using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2.Doktor
{
    public partial class Randevularim : System.Web.UI.Page
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
            var DoktorAd = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
            string Name = (DoktorAd.Kullanci_adi).ToString();
            var doktorID = ent.Doktors.Where(q => q.Doktor_ad == Name).Select(q => q.Doktor_id).FirstOrDefault();
            DateTime bugun = DateTime.Today;
            var hastaId = ent.Randevus.Select(q => q.Hasta_id).FirstOrDefault();
            var hastaAd = ent.Hasta.Where(q => q.Hasta_id == hastaId);
            var counter = ent.Randevus.Where(x => (x.Randevu_date == bugun) && (x.Doktor_id == doktorID)).ToList();

            this.GridViewRandevular.DataSource = ent.Randevus.Where(q => q.Randevu_date == bugun && q.Doktor_id == doktorID)
                .Join(ent.Hasta,
                r => r.Hasta_id,
                h => h.Hasta_id,
                (r, h) => new
                {
                    randevu = r,
                    hasta = h
                })
               .Select(x => new {
                   RandevuSaati_VG = x.randevu.Randevu_saati,
                   HastaAdi_VG = x.hasta.Hasta_ad
                }).ToList();




            this.GridViewRandevular.DataBind();
        }


    }
}