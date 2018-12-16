using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netCore.Models;
using netCore.Controllers;
using netCore.Persistance;

namespace netCore.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        //GET api/values
        [HttpGet]
       public JsonResult Get()
        {
            var product = unitOfWork.ProductRepository.GetAllProducts();
            return Json(product.ToList());
        }

        //GET api/values/id
        [HttpGet("id")]
        public Product GetById(int id)
        {
            Product product = unitOfWork.ProductRepository.GetProduct(id);
            return product;
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //PUT api/values/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        }
    }
}
