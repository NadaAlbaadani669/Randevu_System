using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriTabani;
using Siniflarim;
using System.Threading;

namespace Randevu_Sistem2.HesapOlusturma
{
    public partial class HesapOlusturma : System.Web.UI.Page
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        string tcstr, sifrestr, ad,soyad,fullname,cinsyet, email,telefon;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
       
        protected void olustur_btn_Click(object sender, EventArgs e)
        {
            ad = Text1.Text;
            soyad = soyad_txt.Text;
            fullname = ad+" "+soyad;
            cinsyet = default;
            if (bay_rd.Checked)            
                cinsyet = "Bay";            
            else if (bayan_rd.Checked)
                cinsyet = "Bayan";
            email = email_txt.Text;
            telefon = telefon_txt.Text;
            tcstr = tc_txt.Text;
            sifrestr = pass_txt.Text;
            var tc = ent.Kullanci.Where(q => q.Kullanci_TC == tcstr).ToList();
            var sifre = ent.Kullanci.Where(q => q.Kullanci_sifresi == sifrestr).ToList();
            var isim = ent.Kullanci.Where(q => q.Kullanci_adi == fullname).ToList();
            var emailvar = ent.Kullanci.Where(q => q.Kullanci_email == email).ToList();
            var telefonvar = ent.Hasta.Where(q => q.Hasta_telefon == telefon).ToList();

            if (!String.IsNullOrEmpty(ad) && !String.IsNullOrEmpty(soyad))

            {
                if (!String.IsNullOrEmpty(dob_txt.Text))
                {
                    if (bay_rd.Checked || bayan_rd.Checked)
                    {
                        if (!String.IsNullOrEmpty(email))
                        {
                            if (!String.IsNullOrEmpty(telefon))
                            {
                                if (!String.IsNullOrEmpty(tc_txt.Text))
                                {

                                    if (passAg_txt.Text.Length > 8)
                                    {
                                        if (pass_txt.Text == passAg_txt.Text)
                                        {
                                            if (passAg_txt.Text.Any(char.IsUpper))
                                            {
                                                if (passAg_txt.Text.Any(char.IsLower))
                                                {
                                                    if (tc.Count == 0)
                                                    {
                                                        if (sifre.Count == 0)
                                                        {
                                                            if (isim.Count == 0)
                                                            {
                                                                if (emailvar.Count == 0)
                                                                {
                                                                    if (telefonvar.Count == 0)
                                                                    {
                                                                        VeriTabani.Hasta entity = new VeriTabani.Hasta();
                                                                        VeriTabani.Kullanci dddb = new VeriTabani.Kullanci();

                                                                        /*entity icin*/
                                                                        entity.Hasta_ad = ad + " " + soyad;
                                                                        entity.Hasta_DOB = DateTime.Parse(dob_txt.Text);

                                                                        entity.Hasta_cinsiyet = cinsyet;
                                                                        entity.Hasta_email = email;
                                                                        entity.Hasta_telefon = telefon;
                                                                        entity.Hasta_TC = tc_txt.Text;
                                                                        entity.Hasta_sifresi = pass_txt.Text;

                                                                        /*dddb icin*/

                                                                        dddb.Kullanci_adi = ad + " " + soyad;
                                                                        dddb.Kullanci_email = email;
                                                                        dddb.Kullanci_TC = tc_txt.Text;
                                                                        dddb.Kullanci_Yetki = "Hasta";
                                                                        dddb.Kullanci_sifresi = pass_txt.Text;

                                                                        var ekle = new Siniflarim.Kullanci().Veriekleme(dddb);
                                                                        var ekle2 = new Siniflarim.Hasta().Veriekleme(entity);

                                                                        if (ekle == "1")
                                                                        {
                                                                            ScriptManager.RegisterStartupScript(this, this.GetType(),"alert",
                                                                                "alert('Hesabiniz Basarli Bir Sakilde Olusturdu Simdi Giris Yapabilirsiniz');window.location ='Login.aspx';",true);
                                                                        }
                                                                        else
                                                                            Response.Write("<script>alert('Bir Hata Olustu Bir Daha Deneyniz')</script>");
                                                                    }
                                                                    else warning_lbl.Text = "Bu email kullanilmaktadir baska email Giriniz";
                                                                }
                                                                else warning_lbl.Text = "Bu email kullanilmaktadir baska email Giriniz";
                                                                
                                                            }
                                                            else warning_lbl.Text = "Bu Kullanci Adi Zatan Var";

                                                        }
                                                        else warning_lbl.Text = "Bu Sifre zatan var";

                                                    }
                                                    else warning_lbl.Text = "Bu Tc Zatan Var";                                                    
                                                }
                                                else warning_lbl.Text = "Sifreniz En az 1 karakter Kucuk Olmali";
                                            }
                                            else warning_lbl.Text = "Sifreniz En az 1 karakter Buyuk Olmali";
                                        }
                                        else warning_lbl.Text = "Sifre Farkli Lutfen Yeniden Giriniz Lutfen";
                                    }
                                    else warning_lbl.Text = "Sifreniz En az 8 karakter Olmali ";
                                }
                                else warning_lbl.Text = "TC Numaraniz Giriniz Lutfen";
                            }
                            else warning_lbl.Text = "Telefon Numaraniz Giriniz Lutfen";

                        }
                        else warning_lbl.Text = "Emailiniz Giriniz Lutfen";

                    }
                    else warning_lbl.Text = "Cinsyetiniz Secin Lutfen";
                }
                else warning_lbl.Text = "Dogum Tarihiniz Giriniz Lutfen";
            }
            else warning_lbl.Text = "Adiniz Giriniz Lutfen";


            
           /* if (pass_txt.Value == passAg_txt.Value)
            {
                string cinsyet = default;
                VeriTabani.Hasta entity = new VeriTabani.Hasta();
                VeriTabani.Kullanci dddb = new VeriTabani.Kullanci();

                *//*entity icin*//*
                entity.Hasta_ad = Text1.Value +" "+ soyad_txt.Value;
                entity.Hasta_DOB = DateTime.Parse(dob_txt.Value);
                if (bay_rd.Checked)
                {
                    cinsyet = "Bay";
                }
                else if (bayan_rd.Checked)
                {
                    cinsyet = "Bayan";
                }
                entity.Hasta_cinsiyet = cinsyet;
                entity.Hasta_email = email_txt.Value;
                entity.Hasta_telefon = telefon_txt.Value;
                entity.Hasta_TC = tc_txt.Value;
                entity.Hasta_sifresi = pass_txt.Value;

                *//*dddb icin*//*

                dddb.Kullanci_adi = Text1.Value +" "+ soyad_txt.Value;                
                dddb.Kullanci_email = email_txt.Value;
                dddb.Kullanci_TC = tc_txt.Value;
                dddb.Kullanci_Yetki = "Hasta";
                dddb.Kullanci_sifresi = pass_txt.Value;

                var ekle = new Siniflarim.Kullanci().Veriekleme(dddb);
                var ekle2 = new Siniflarim.Hasta().Veriekleme(entity);

                if (ekle == "1")
                {                                    
                    Response.Redirect("/Login.aspx");
                }
                else
                    Response.Write("<script>alert('Bir Hata Olustu Bir Daha Deneyniz')</script>");
            }
            else
            {
                Response.Write("<script>alert('Sifre Farkli Lutfen Yeniden Giriniz!!!!!!')</script>");
            }                     */
                     

        }
    }
}