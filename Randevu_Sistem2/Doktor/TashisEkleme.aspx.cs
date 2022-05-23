using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Randevu_Sistem2.Doktor
{
    public partial class TashisEkleme : System.Web.UI.Page
    {
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();
        string hasta ,  doktor , randevuNo, tashis, ilac;
        int hastaNo, doktorNo,bla;
        DateTime bugun = DateTime.Today;
        private object randevuinfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hastaSec();
            }
        }

        private void hastaSec()
        {
            var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
            doktor = (user.Kullanci_adi).ToString();
            doktorNo = ent.Doktors.Where(q => q.Doktor_ad == doktor).Select(q => q.Doktor_id).First();
            var bilgiler = ent.Randevus.Where(q => q.Randevu_date == bugun && q.Doktor_id == doktorNo)
                .Join(ent.Hasta , 
                r=> r.Hasta_id,
                h => h.Hasta_id,
                (r,h)=> new { 
                    br = r.Hasta_id,
                    bh = h.Hasta_ad
                })
                .Select(x=> new { 
                    hastaad = x.bh,
                    hadtaid = x.br
                }).ToList();
            
           
            

            hasta_drp.DataSource = bilgiler;
            hasta_drp.DataTextField = "hastaad";
            hasta_drp.DataValueField = "hadtaid";    
            hasta_drp.DataBind();
            if (hasta_drp.Items.Count !=0)
                hasta_drp.Items.Insert(0, "Hasta Secin");
            else
                hasta_drp.Items.Insert(0, "Bugun Hastaniz Yok!!");



        }
        protected void tashis_cbx_CheckedChanged(object sender, EventArgs e)
        {
            pnlResete.Visible = tashis_cbx.Checked;
        }

        protected void hasta_drp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected void tashis_btn_Click(object sender, EventArgs e)
        {
            var user = (VeriTabani.Kullanci)System.Web.HttpContext.Current.Session["kullanci"];
            hasta = hasta_drp.SelectedItem.ToString();
            hastaNo = ent.Hasta.Where(q => q.Hasta_ad == hasta).Select(q => q.Hasta_id).First();
            doktor = (user.Kullanci_adi).ToString();
            doktorNo = ent.Doktors.Where(q => q.Doktor_ad == doktor).Select(q => q.Doktor_id).First();
            randevuNo = ent.Randevus.Where(q => q.Hasta_id == hastaNo && q.Doktor_id == doktorNo && q.Randevu_date == bugun).Select(q => q.Randevu_no).First().ToString();
            tashis = tashis_txt.Text;
            if (tashis_cbx.Checked)
                ilac = resete_txt.Text;
            else
                ilac = "Doktor ilac yazmadi";

            VeriTabani.Hasta_durumu tashisEkle = new VeriTabani.Hasta_durumu();

            tashisEkle.Hasta_id = hastaNo;        
            tashisEkle.Doktor_id = doktorNo;           
            tashisEkle.Randevu_no = Int32.Parse(randevuNo);
            tashisEkle.Tashis = tashis;
            tashisEkle.Resete = ilac;

            var ekle = new Siniflarim.Doktor().TashisEkle(tashisEkle);

            if (ekle == "1")
                massege.Text = "Tashisiniz eklendi";
            else massege.Text = "Bir hata olustu bir daha deneyiniz";
            

        }

        
    }
}