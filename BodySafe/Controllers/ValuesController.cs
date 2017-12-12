using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BodySafe;

using Microsoft.AspNetCore.Mvc;
using ViewModels.LobbyCat;

namespace BodySafe.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public static void Ret()
        {
         var data =  X.Deserialize();
          
        }

        // GET api/values
        [HttpGet]
        public ROWSET Get()
        {
         var a= X.Deserialize();
            return a;
           // return new string[] { "value1", "value2" };
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
