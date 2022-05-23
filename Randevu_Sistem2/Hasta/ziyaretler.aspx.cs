using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2.Hasta
{
    public partial class Gesmisim : System.Web.UI.Page
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        string hasta;
        int hastaid;
        private string info;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                filldata();
                /*var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
                hasta = (user.Kullanci_adi).ToString();
                hastaid = ent.Hasta.Where(q => q.Hasta_ad == hasta).Select(q => q.Hasta_id).FirstOrDefault();
                var bilgi = ent.Hasta_durumu.Where(q => q.Hasta_id == hastaid)
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
                    RTarih = hd.randevu.Randevu_date.ToString()
                }).Select(x => new {
                    DoktorAdi = x.dokotorAd,
                    Randevu_Tarihi = x.RTarih,
                }).ToList();

               
                if (bilgi.Count> 0)
                {
                    info = "";
                    for (int i = 0; i < bilgi.Count; i++)
                    {
                        info += "<div class=\"smallBlock\">";
                        info += "<h4> ID : </h4> <p>" + i+1 +"</p>";
                        info += "<h4> Doktor Adi : </h4> <p>" + bilgi[i].DoktorAdi + "</p>";
                        info += "<h4> Randevu Tarihi : </h4> <p>" + bilgi[i].Randevu_Tarihi + "</p>";
                        info += "</div>";
                    }
                }
                lt_z.Text += info;*/
            }
        }
        private void filldata()
        {
            var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
            hasta = (user.Kullanci_adi).ToString();
            hastaid = ent.Hasta.Where(q => q.Hasta_ad == hasta).Select(q => q.Hasta_id).FirstOrDefault();

            this.zGV.DataSource = ent.Hasta_durumu.Where(q => q.Hasta_id == hastaid)
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
                RTarih = hd.randevu.Randevu_date.ToString()
            }).Select(x => new {
                da_gv = x.dokotorAd,
                rt_vg = x.RTarih,
            }).ToList();

            this.zGV.DataBind();
        }

    }
}