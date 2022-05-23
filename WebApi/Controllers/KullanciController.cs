using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class KullanciController : ApiController
    {
        List<Kullanci> kullancilar = new List<Kullanci>();
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();        

        public KullanciController()
        {
            var list = ent.Kullanci.OrderBy(q => q.Kullanci_id).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                kullancilar.Add(new Kullanci
                {
                    id = list[i].Kullanci_id,
                    ad = list[i].Kullanci_adi,
                    tcNo = list[i].Kullanci_TC,
                    email = list[i].Kullanci_email,
                    yetki = list[i].Kullanci_Yetki
                });
            }
        }

        [HttpGet]
        public List<Kullanci> GetKullanci()
        {            
            return kullancilar;
        }
        
        [HttpGet]
        public Kullanci GetKullanci(int id)
        {
            return kullancilar.Where(x => x.id == id).FirstOrDefault();
        }
    }
}
