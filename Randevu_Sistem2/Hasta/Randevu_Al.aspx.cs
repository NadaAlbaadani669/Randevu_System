using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2.Hasta
{
    public partial class Randevu_Al : System.Web.UI.Page
    {
        string birim, doktor, RTarih, RSaat, uzmanlikNo, doktorNo, hasta;
        int uzmanlikID, doktorNoInt;
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BirimAl();
            }
        }

        private void BirimAl()
        {
            var birimIslemler = ent.Uzmanliks.ToList();
            birim_drp.DataSource = birimIslemler;

            birim_drp.DataTextField = "uzmanlik_adi";
            birim_drp.DataValueField = "uzmanlik_id";
            birim_drp.DataBind();
            birim_drp.Items.Insert(0 , new ListItem(" Birim Seciniz", "0"));
            birim_drp.SelectedIndex = 0 ;
        }

        protected void birim_drp_SelectedIndexChanged(object sender, EventArgs e)
        {
            birim = birim_drp.SelectedItem.ToString();
            uzmanlikNo = birim_drp.SelectedValue;
            uzmanlikID = Int32.Parse(uzmanlikNo);
            

            if (uzmanlikNo != "0")
            {
                var doktorIslemleri = ent.Doktors.Where(q => q.Doktor_uzmanlik == uzmanlikID).ToList();
                

                doktor_drp.DataSource = doktorIslemleri;
                doktor_drp.DataTextField = "Doktor_ad";
                doktor_drp.DataValueField = "Doktor_id";
                doktor_drp.DataBind();
                doktor_drp.Items.Insert(0, new ListItem("Doktor Secin", "0"));
                doktor_drp.SelectedIndex = 0;
            }
            else
            {
                doktor_drp.Items.Insert(0, "Bu Birim Icin Doktor Yok");
                doktor_drp.DataBind();
            }

        }
        protected void RandevuAl_btn_Click(object sender, EventArgs e)
        {
            birim = birim_drp.SelectedItem.ToString();
            var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
            hasta = (user.Kullanci_adi).ToString();
                         
            RTarih = RTarih_txt.Value;
            RSaat = RSaat_txt.Value;
            doktor = doktor_drp.SelectedItem.ToString();
            doktorNo = doktor_drp.SelectedValue;
            doktorNoInt = Int32.Parse(doktorNo);

            var HastaID = ent.Hasta.Where(q => q.Hasta_ad == hasta).Select(q => q.Hasta_id).First();
            
            VeriTabani.Randevu rendevuAl = new VeriTabani.Randevu();

            if (birim != null)
            {
                if (doktor != null)
                {
                    if (RTarih != null)
                    {
                        if (RSaat != null)
                        {
                            DateTime bla = DateTime.Parse(RTarih);
                            var makeSure = ent.Randevus.Where(q => q.Randevu_date == bla && q.Hasta_id == HastaID && q.Doktor_id == doktorNoInt).FirstOrDefault();
                            if (makeSure == null)
                            {
                                rendevuAl.Randevu_date = DateTime.Parse(RTarih);
                                rendevuAl.Doktor_id = doktorNoInt;                                
                                rendevuAl.Hasta_id = HastaID;                                
                                rendevuAl.Randevu_saati = TimeSpan.Parse(RSaat);

                                var ekle = new Siniflarim.Hasta().RandevuEkleme(rendevuAl);

                                if (ekle == "1")
                                    massege.Text = "Randevunuz alindi";
                                else massege.Text = "Bir siknti oldu yeniden deneyin";
                            }
                            else massege.Text = "O tarih ta bu Doktor ile Randevunuz var baska tarih yada Doktor ";


                        }
                        else massege.Text = "you didnt fill the Time";
                    }
                    else massege.Text = "you didnt fill the Tarih";
                }
                else massege.Text = "you didnt chose the doktor";
            }
            else massege.Text = "you didnt chose the birim";
           
        }
    }
}