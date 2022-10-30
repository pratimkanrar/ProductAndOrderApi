using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Entities;
using ECommerceApi.Interfaces;
using ECommerceApi.Database;
namespace ECommerceApi.Services
{
    public class OrderService : OrderInterface
    {
        private readonly ECommerceDBContext context;
        public OrderService()
        {
            this.context = new ECommerceDBContext();
        }
        public void Add(Order Order)
        {
            context.Orders.Add(Order);
            context.SaveChanges();
        }
        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }
        public Order GetById(int id)
        {
            Order Order = context.Orders.SingleOrDefault(i => i.OrderId == id);
            return Order;
        }
    }
}