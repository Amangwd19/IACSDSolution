using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTECommercehome.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Gerbera", "Lily", "Orchid", "Dafodils" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string flower = string.Empty;
            switch (id)
            {
                case 1:flower = "Gerbera";
                    break;
                case 2:
                    flower = "Lily";
                    break;
                case 3:
                    flower = "Orchid";
                    break;
                case 4:
                    flower = "Dafodils";
                    break;
            }
            return flower;
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
        }
    }
}
