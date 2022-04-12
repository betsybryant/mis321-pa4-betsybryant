using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mis321_pa4_betsybryant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Songs : ControllerBase
    {
        // GET: api/Songs -async
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Songs -async/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Songs -async
        [HttpPost]
        public void Post([FromBody] string value) //add
        {
            
        }

        // PUT: api/Songs -async/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) //update
        {

        }

        // DELETE: api/Songs -async/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
