using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BodySafe.Controllers
{
    // [Produces("application/json")]
    [ResponseCache(Duration = 60)]
    [Route("api/Barber")]
    public class InspectionController : Controller
    {
        //persisted data in memory
        List<Inspection> BarberList = new List<Inspection>();
        public static List<Inspection> BarberHolderList = new List<Inspection>();
        string endpoint = "http://app.toronto.ca/opendata/bodysafe/full_list.json?v=1.00&row_start=1&row_count=12000";


     //        public async Task<List<Inspection>> Index()

         [HttpGet]
        public async Task<List<Inspection>> Index()
        {
            //HTTP client Get requests amara
            string page = endpoint;
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(endpoint))
            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();

                if (data != null)
                {
                    //deserialize
                    BarberList = JsonConvert.DeserializeObject<List<Inspection>>(data);

                    //persist in list
                    BarberHolderList = BarberList;
                }
            }
            //tattoos
            //DateTime yyyy-mm-dd DateTime.ToString(@"MM/dd/yyyy HH\:mm\:ss.fff")

            var d = BarberHolderList.FindAll(x => x.servTypeDesc == "Tattooing").ToList();
            //Barbering & Hairdressing
            //    var d = BarberHolderList.FindAll(x => x.servTypeDesc == "Barbering & Hairdressing").ToList();

            //var d = BarberHolderList.FindAll(x => x.inspStatusDesc == "Conditional").ToList();

            //infrTypeDesc

          // var d = BarberHolderList.FindAll(x => x.infrTypeDesc == "blood/body").ToList();


            return d;



        }
    }
}