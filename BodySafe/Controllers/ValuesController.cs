using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BodySafe;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModels.LobbyCat;

namespace BodySafe.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ApiContext ctx = LobbyFactory.db;
        public class Holder
        {

            public string FirmName { get; set; }
            public string Subject { get; set; }
            public string Particular { get; set; }
            public string Benifitor { get; set; }



        }



        [HttpGet]
        public IActionResult Get()
        {
            //old saves
            // var x =  LobbyFactory.Deserialize();

           

            List<Holder> hList = new List<Holder>();

            //eagar loading
            var c = ctx.LobbyActivity.Include(x => x.Firms.Firm).Include(x => x.Beneficiaries.BENEFICIARY)
                .Where(x => x.Id == x.Firms.Id && x.Id == x.Beneficiaries.Id);
            //  var d = ctx.LobbyActivity.Select(x => new { x.Beneficiaries.BENEFICIARY., x.ServedInObiOne, x.EquipmentOwned }).ToList();

            Holder h1 = null;
            foreach (var item in c)
            {
                h1 = new Holder();
                var lld = item.Firms.Firm;


                h1.Particular = item.Particulars;
                h1.Subject = item.SubjectMatter;
                foreach (var item2 in lld)
                    if (item2.Name != null)

                        h1.FirmName = item2.Name;

                foreach (var item3 in item.Beneficiaries.BENEFICIARY)

                    if (item3.Name != null)
                        h1.Benifitor = item3.Name;



                hList.Add(h1);

            }

            return Ok(hList.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
