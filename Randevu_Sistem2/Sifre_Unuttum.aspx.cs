using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2.Sifre_unuttum
{
    public partial class Sifre_Unuttum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sifre_goster_Click(object sender, EventArgs e)
        {
            string tc = tc_txt.Value;
            string email = email_txt.Value;
            string yetki = turu_drp.Value;
         
            
                var s = new Siniflarim.Kullanci().Sifre_goster(tc, email, yetki);
                if (s != null)
                {                       
                    Label1.Text = "Sifreniz : ==>"+ s;                        
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this,
                    this.GetType(),
                    "alert",
                    "alert('Biligleriniz Yalnis Yenidenn Deneyin.');window.location ='Sifre_Unuttum.aspx';",
                    true);
                }
                       
                    
          
           

            
        }
    }
}