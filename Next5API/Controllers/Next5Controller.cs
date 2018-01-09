using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Next5API.Controllers
{
    //[Produces("application/json")]
    [Route("api/Next5")]
    public class Next5Controller : Controller
    {
        // GET: api/Next5
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Next5DataStore.Current.Next5);
        }

        // GET: api/Next5/5
        //[HttpGet("{id}", Name = "Get")]
        //public IActionResult Get(int id)
        //{
        //    return Ok(Next5DataStore.Current.Next5);
        //}
        
        //// POST: api/Next5
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/Next5/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
