using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BOL;
using BLL;

namespace RESTECommercehome.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return BusinessManager.GetAllProducts();
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return BusinessManager.GetProduct(id);
        }

        // POST: api/Product
        public void Post([FromBody]Product newProduct)
        {
            BusinessManager.Insert(newProduct);
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]Product existingProduct)
        {
            BusinessManager.Update(existingProduct);
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
