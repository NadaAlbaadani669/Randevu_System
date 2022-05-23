using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2
{
    public partial class TopBar : System.Web.UI.UserControl
    {
        string bilgi;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
                string ad = (user.Kullanci_adi).ToString();

                bilgi = "";
                bilgi += " <span class=\"title1\"><h3>" + ad + "</h3></span>";
                lt_ad.Text = bilgi;
            }
            
        }
    }
}