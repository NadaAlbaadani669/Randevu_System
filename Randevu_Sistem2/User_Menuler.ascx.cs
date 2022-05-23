using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2
{
    public partial class User_Menuler : System.Web.UI.UserControl
    {
        private string bilgi;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var yetki = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
                var menu = new Siniflarim.Menu().GetByYetki(yetki.Kullanci_Yetki).ToList();

                if (menu != null)
                {
                    bilgi = "";
                    for (int i = 0; i < menu.Count; i++)
                    {
                        bilgi += "<li>";
                        bilgi += "<a href = \"" + menu[i].Menu_adres + "\">";
                        bilgi += "<span class=\"icon\"><ion-icon name=\"" + menu[i].Menu_iconAd + "\"></ion-icon></span>";
                        bilgi += "<span class=\"title\">" + menu[i].Menu_ad + "</span>";
                        bilgi += "</a></li>";
                    }

                }
                lt_menu.Text += bilgi;
            }
          

        }
    }
}