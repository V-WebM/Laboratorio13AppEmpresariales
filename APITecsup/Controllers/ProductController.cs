using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APITecsup.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Producto> Get()
        {
            List<Producto> products = new List<Producto>();
            products.Add(new Producto {
                Nombre= "Laptop",
                Descripcion= "Laptop 2",
                PrecioVenta= 1000.0,
                EstaActivo= true
            });
            return products;
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
