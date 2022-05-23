using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DoktorController : ApiController
    {
        List<DoktorApi> doktorlar = new List<DoktorApi>();
        VeriTabani.RandevuSystemEntities ent = new VeriTabani.RandevuSystemEntities();

        public DoktorController()
        {
            var dliste = ent.Doktors.OrderBy(q => q.Doktor_id).ToList();
            for (int i = 0; i < dliste.Count ; i++)
            {
                doktorlar.Add(new DoktorApi
                {
                    id = dliste[i].Doktor_id,
                    ad = dliste[i].Doktor_ad,
                    tcNo = dliste[i].Doktor_TC,
                    email = dliste[i].Doktor_email,
                    telefon = dliste[i].Doktor_telefon,
                    DateOfBirth = dliste[i].Doktor_DOB.ToString()
                });
            }
        }

        [HttpGet]
        public List<DoktorApi> GetDoktor()
        {
            return doktorlar;
        }

        [HttpGet]
        public DoktorApi GetDoktor(int id)
        {
            return doktorlar.Where(q => q.id == id).FirstOrDefault();
        }
    }
}
