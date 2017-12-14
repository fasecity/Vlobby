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

            return Ok(lobbList);
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
            var c = ctx.CommsLobbActivity.Include(x => x.Firms).ThenInclude(firms => firms.Firm)
            .Include(x => x.Beneficiaries).ThenInclude(b => b.BENEFICIARY)
            .Include(x => x.Registrant)
            .Include(x => x.Communications)
            .ThenInclude(com => com.Communication);
            var d = c.ToList();
            return d;
        } 
    }

}
