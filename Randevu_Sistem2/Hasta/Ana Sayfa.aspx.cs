using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2.Hasta
{
    public partial class Ana_Sayfa : System.Web.UI.Page
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        string hasta;
        int hastaid; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillData();
            }
        }
        private void fillData()
        {
            var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
            hasta = (user.Kullanci_adi).ToString();
            hastaid = ent.Hasta.Where(q => q.Hasta_ad == hasta).Select(q => q.Hasta_id).FirstOrDefault();

            this.RandevuVG.DataSource = ent.Randevus.Where(q => q.Hasta_id == hastaid && q.Randevu_date > DateTime.Now)                
                .Join(ent.Doktors,
                hd => hd.Doktor_id,
                d => d.Doktor_id,
                (hd, d) => new {
                    dokotorAd = d.Doktor_ad,
                    RTarih = hd.Randevu_date.ToString(),
                    RSaat = hd.Randevu_saati
                }).Select(x => new {
                    da_vg = x.dokotorAd,
                    rt_vg = x.RTarih,
                    rs_vg = x.RSaat

                }).ToList();

            this.RandevuVG.DataBind();

        }
    }
}