using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Next5API.Controllers
{
    [Route("api/Race")]
    public class RaceController : Controller
    {
        // GET: api/Race
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(RaceDataStore.Current.Races);
        }

        // GET: api/Race/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(RaceDataStore.Current.Races.FirstOrDefault(r=>r.RaceNo == id));
        }
        
        // POST: api/Race
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Race/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
