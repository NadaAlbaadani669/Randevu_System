using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2
{
    public partial class GenelBilgiler : System.Web.UI.UserControl
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        string ad, tcNo,dob,telefon, email, yetki; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
                ad = (user.Kullanci_adi).ToString();
                tcNo = (user.Kullanci_TC).ToString();
                yetki = (user.Kullanci_Yetki).ToString();
                email = (user.Kullanci_email).ToString();

                if(yetki == "Doktor")
                {
                    dob = ent.Doktors.Where(q => q.Doktor_ad == ad).Select(q => q.Doktor_DOB.ToString()).First().ToString();
                    telefon = ent.Doktors.Where(q => q.Doktor_ad == ad).Select(q => q.Doktor_telefon).First().ToString();
                }
                else if(yetki == "Hasta")
                {
                    dob = ent.Hasta.Where(q => q.Hasta_ad == ad).Select(q => q.Hasta_DOB.ToString()).First().ToString();
                    telefon = ent.Hasta.Where(q => q.Hasta_ad == ad).Select(q => q.Hasta_telefon).First().ToString();
                }
                else if(yetki == "Sekreter")
                {
                    dob = ent.Sekreters.Where(q => q.Sekreter_ad == ad).Select(q => q.Sekreter_DOB.ToString()).First().ToString();
                    telefon = ent.Sekreters.Where(q => q.Sekreter_ad == ad).Select(q => q.Sekreter_telefonb).First().ToString();
                }

                ad_txt.Text = ad;
                tc_txt.Text = tcNo;
                dob_txt.Text = dob;
                tel_txt.Text = telefon;
                email_txt.Text = email;
               
            }

        }
    }
}