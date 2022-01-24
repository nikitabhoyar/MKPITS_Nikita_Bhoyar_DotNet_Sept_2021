using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEPAPI_DATA_GET_EXAMPLE.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        List<string> students = new List<string>()
        {
            "Nikita", "Akash" ,"Nilesh" ,"Pooja"
        };
        public IEnumerable<string> Get()
        {
            return students;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return students[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            students.RemoveAt(id);
        }
    }
}
