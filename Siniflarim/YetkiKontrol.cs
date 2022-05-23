using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Siniflarim
{
    public enum yetki
    {
        Doktor = 1,
        Hasta = 2,
        Sekreter=3
    }
    public class YetkiKontrol: System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            var yetki = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
            if (yetki.Kullanci_Yetki != "Doktor")
            {
                Response.Redirect("/Login.aspx");
            }
            base.OnLoad(e);
        }
    }
}
