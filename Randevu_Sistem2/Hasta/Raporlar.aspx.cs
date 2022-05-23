using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2.Hasta
{
    public partial class Raporlar : System.Web.UI.Page
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
            hastaid = ent.Hasta.Where(q=> q.Hasta_ad == hasta).Select(q=> q.Hasta_id).FirstOrDefault();

            this.RaporGV.DataSource = ent.Hasta_durumu.Where(q => q.Hasta_id == hastaid)
                .Join(ent.Randevus,
                hdurum => hdurum.Randevu_no,
                r => r.Randevu_no,
                (hdurum, r) => new
                {
                    durum = hdurum,
                    randevu = r
                })
                .Join(ent.Doktors,
                hd => hd.durum.Doktor_id,
                d => d.Doktor_id,
                (hd, d) => new {
                    dokotorAd = d.Doktor_ad,
                    RTarih = hd.randevu.Randevu_date.ToString(),
                    tashis = hd.durum.Tashis
                }).Select(x => new {
                    DA_gv = x.dokotorAd,
                    RT_gv = x.RTarih,
                    DT_vg = x.tashis

                }).ToList();

            this.RaporGV.DataBind();

        }
    }
}