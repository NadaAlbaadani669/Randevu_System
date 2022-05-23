using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace Randevu_Sistem2
{
    public class Global : System.Web.HttpApplication
    {
        void Yonlendir(RouteCollection rot)
        {
            rot.MapPageRoute("Login","Login","~/Login.aspx");
            rot.MapPageRoute("Signup", "Signup", "~/HesapOlusturma.aspx");
            rot.MapPageRoute("Forget", "Sifre Unuttum", "~/Sifre_Unuttum.aspx");

            //Hasta Yetkisi
            rot.MapPageRoute("Ana Sayfa", "Hasta/AnaSayfasi", "~/Hasta/Ana Sayfa.aspx");
            rot.MapPageRoute("Hasta Bilgileri", "Hasta/GenelBilgiler", "~/Hasta/GenelBilgileri.aspx");
            rot.MapPageRoute("Hasta Reseteleri", "Hasta/Reseteleri", "~/Hasta/Resete.aspx");
            rot.MapPageRoute("Hasta Raporlari", "Hasta/Raporlari", "~/Hasta/Raporlar.aspx");
            rot.MapPageRoute("Hasta Ziyaretleri", "Hasta/Ziyaretler", "~/Hasta/ziyaretler.aspx");
            rot.MapPageRoute("Randevu Al", "Hasta/RandevuAlma", "~/Hasta/Randevu_al.aspx");


            //Doktor Yetkisi hocam hale hasta sayfasinde calisiyorum deger Routerler final projede ekleyecegim
            
            rot.MapPageRoute("Randevularim","Doktor/Randevulari","~/Doktor/Randevularim.aspx");
            rot.MapPageRoute("Genel Bilgilerim", "Doktor/GenelBilgileri", "~/Doktor/GenelBilgileri.aspx");
            rot.MapPageRoute("Tashis Ekleme", "Doktor/TashisEkleme", "~/Doktor/TashisEkleme.aspx");


            //Sekreter Yetkisi
            rot.MapPageRoute("Randevuler","Sekreter/Hastalarin Randevularin","~/Sekerter/Randevular.aspx");
            rot.MapPageRoute("Genel Bilgilerimi", "Sekreter/GenelBilgileri", "~/Sekerter/GenelBilgileri.aspx");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            Yonlendir(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}