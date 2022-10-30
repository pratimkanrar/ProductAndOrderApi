using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Entities;
using ECommerceApi.Services;
namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService service;
        public ProductController()
        {
            this.service = new ProductService();
        }
        [Route("GetAllProducts")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> Products = service.GetAll();
            return StatusCode(200, Products);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            Product Product = service.GetById(id);
            return StatusCode(200, Product);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Product Product)
        {
            service.Add(Product);
            return StatusCode(200, Product);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return StatusCode(200, "Product with " + id + " Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Product Product)
        {
            service.Edit(Product);
            return StatusCode(200, Product);
        }

    }
}