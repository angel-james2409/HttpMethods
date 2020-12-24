using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        static List<String> phones = new List<string>()
        {
          "samsung","vivo","mi","oppo"
        };
        // GET: api/<PhonesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return phones;
        }

        // GET api/<PhonesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return phones[id];
        }

        // POST api/<PhonesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            phones.Add(value);
        }

        // PUT api/<PhonesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            phones.Add(value);
        }

        // DELETE api/<PhonesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            phones.RemoveAt(id);
        }
    }
}
