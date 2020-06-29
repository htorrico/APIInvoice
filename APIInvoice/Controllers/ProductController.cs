using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIInvoice.Controllers
{
    public class ProductController : ApiController
    {
        private ProductService service = new ProductService();

        public List<Product> Get()
        {
            return service.Get();
        }

        public Product Get(int id)
        {
            return service.GetById(id);
        }

        public void Post([FromBody] Product value)
        {
           service.Insert(value);
        }
    }
}
