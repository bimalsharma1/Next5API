using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Next5API.Controllers
{
    [Route("api/Next5")]
    public class Next5Controller : Controller
    {
        // GET: api/Next5
        [HttpGet]
        public ActionResult Get()
        {
            ChangeDateInDataStore(); //note: this has been added to continuously change start time for next 5 to appear. Normally there will be a data updated by users

            return Ok(Next5DataStore.Current.Next5
                .Where(n => n.Races
                            .OrderBy(r => r.RaceClosedTime)
                            .All(r=>r.IsSuspended==false))
                .Take(5));
        }

        private void ChangeDateInDataStore()
        {
            foreach(var next5 in Next5DataStore.Current.Next5)
            {
                foreach(var race in next5.Races)
                {
                    race.RaceClosedTime = DateTime.UtcNow.AddSeconds(60);
                };
            }
        }
    }
}
