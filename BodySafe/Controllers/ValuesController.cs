using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommsModel;

namespace BodySafe.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ApiContext ctx = LobbyFactory.db;


        [HttpGet]
        public IActionResult Get()
        {
            //calls save  comment out untill saving
            //SaveBatchXml(); /-- dont call unless saving
            var listHolder = QueryAllList();
            var lobbList = listHolder;

            var uber = new List<Loob>();
            Loob loobobj = null;
            foreach (var item in lobbList)           
            {
                loobobj = new Loob
                {
                    Id = item.Id,
                    Particulars = item.Particulars,
                    SubjectMatter = item.SubjectMatter,
                    Registrant = item.Registrant,
                    Beneficiaries = item.Beneficiaries,
                    Communications = item.Communications,
                    Firms = item.Firms,                                  
                };
               
            }
            uber.Add(loobobj);

            return Ok(uber);
           // return Ok(lobbList);
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


        //-------------------------private Methods-----------------------------------
        private void SaveBatchXml()
        {
            //-- batch saves xml
            var x = XMLCommLobb.Deserialize();
        }

        private List<COMMSLOBBROW> QueryAllList()
        {
            var c = ctx.CommsLobbActivity
            .Include(x => x.Firms).ThenInclude(firms => firms.Firm)
            .Include(x => x.Beneficiaries).ThenInclude(b => b.BENEFICIARY)
            .Include(x => x.Registrant)
            .Include(x => x.Communications).ThenInclude(x => x.Communication);
            
            var d = c.ToList();
            return d;
        } 

        private List<COMMSLOBBROW> Comunicated()
        {
            var c = ctx.CommsLobbActivity
           .Include(x => x.Firms).ThenInclude(firms => firms.Firm)
           .Include(x => x.Beneficiaries).ThenInclude(b => b.BENEFICIARY)
           .Include(x => x.Registrant)

           .Include(x => x.Communications.Communication).Take(1);
            //.OrderByDescending(x => x.Communications.Id)
            //.OrderBy(x => x.Id);
            /*ThenInclude(x => x.Communication).Take(2)*/
            /*.OrderBy(x => x.Id)*/
            var d = c.ToList();
            return d;
        }


    }

    public class Loob
    {
        public int Id { get; set; }
        public string SubjectMatter { get; set; }
        public string Particulars { get; set; }

        public virtual RegistrantT Registrant { get; set; }
    
        public virtual CommunicationsT Communications { get; set; }
       
        public virtual FirmsT Firms { get; set; }
       
        public virtual BeneficiariesT Beneficiaries { get; set; }
    }
}
