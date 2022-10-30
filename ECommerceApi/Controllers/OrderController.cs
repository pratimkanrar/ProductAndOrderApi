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
    public class OrderController : ControllerBase
    {
        private readonly OrderService service;
        public OrderController()
        {
            this.service = new OrderService();
        }
        [Route("GetAllOrders")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Order> Orders = service.GetAll();
            return StatusCode(200, Orders);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            Order Order = service.GetById(id);
            return StatusCode(200, Order);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Order Order)
        {
            service.Add(Order);
            return StatusCode(200, Order);
        }
    }
}