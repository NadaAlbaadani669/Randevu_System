using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Siniflarim;

namespace Randevu_Sistem2.LogIn
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            string tc = tc_txt.Value;
            string pass = pass_txt.Value;
            string yetki = turu_drp.Value;

            var kullanci = new Siniflarim.Kullanci().hesap_var_mi(tc , pass, yetki);
            if (kullanci != null)
            {
                Session["kullanci"] = kullanci;
                if (kullanci.Kullanci_Yetki == "Sekreter")
                    Response.Redirect("/Sekerter/Randevular.aspx");
                else if (kullanci.Kullanci_Yetki == "Hasta")
                    Response.Redirect("/Hasta/Ana Sayfa.aspx");
                else if (kullanci.Kullanci_Yetki == "Doktor")
                    Response.Redirect("/Doktor/Randevularim.aspx");

            }
            else
            {
                ScriptManager.RegisterStartupScript(this,
                    this.GetType(),
                    "alert",
                    "alert('TC numara Veya Sifreniz Yanlistir, Tekrar deneyin.');window.location ='Login.aspx';",
                    true);
            }

        }
                   
    }
}