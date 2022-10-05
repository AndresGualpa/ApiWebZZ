using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers.ACCESO
{
    public class AccesoController : ApiController
    {
       





        // GET: api/Acceso
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Acceso/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Acceso
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Acceso/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Acceso/5
        public void Delete(int id)
        {
        }
    }
}
