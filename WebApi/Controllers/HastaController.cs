using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class HastaController : ApiController
    {
        List<HastaApi> hastalar = new List<HastaApi>();
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();

        public HastaController()
        {
            var Hliste = ent.Hasta.OrderBy(q => q.Hasta_id).ToList();
            for (int i = 0; i < Hliste.Count; i++)
            {
                hastalar.Add(new HastaApi { 
                    id = Hliste[i].Hasta_id,
                    ad = Hliste[i].Hasta_ad,
                    tcNo = Hliste[i].Hasta_TC,
                    email = Hliste[i].Hasta_email,
                    telefon = Hliste[i].Hasta_telefon,
                    DateOfBirth = Hliste[i].Hasta_DOB.ToString()
                });
            }
        }

        [HttpGet]
        public List<HastaApi> GetHasta()
        {
            return hastalar;
        }
        [HttpGet]
        public HastaApi GetHasta(int id)
        {
            return hastalar.Where(x => x.id == id).FirstOrDefault();
        }
    }
}
