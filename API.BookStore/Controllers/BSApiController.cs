using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.BookStore.Controllers
{
    public class BSApiController : ApiController
    {
        // GET: api/BookAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BookAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BookAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BookAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BookAPI/5
        public void Delete(int id)
        {
        }
    }
}
