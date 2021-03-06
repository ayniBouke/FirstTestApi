using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value0", "value1", "value2", "value3" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value " + id;
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return value + " Added";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody] string value)
        {
            return value + " Updated with Id "+id;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
