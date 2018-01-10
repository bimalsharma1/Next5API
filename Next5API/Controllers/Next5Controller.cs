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
            return Ok(Next5DataStore.Current.Next5
                .Where(n => n.Races
                            .OrderBy(r => r.RaceClosedTime)
                            .All(r=>r.IsSuspended==false))
                .Take(5));
        }
    }
}
