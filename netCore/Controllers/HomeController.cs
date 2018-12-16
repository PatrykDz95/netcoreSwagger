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
        public JsonResult GetById(int id)
        {
            Product product = unitOfWork.ProductRepository.GetProduct(id);
            return Json(product);
        }

        //POST api/values
        [HttpPost]
        public JsonResult Post(Product product)
        {
            unitOfWork.ProductRepository.UpdateProduct(product);
            unitOfWork.Save();
            return Json(product);
        }

        //PUT api/values/id
        [HttpPut("{id}")]
        public JsonResult Put(Product product)
        { 
            unitOfWork.ProductRepository.InsertProduct(product);
            unitOfWork.Save();
            return Json(product);       
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            unitOfWork.ProductRepository.DeleteProduct(id);
            unitOfWork.Save();
        }
    }
}
