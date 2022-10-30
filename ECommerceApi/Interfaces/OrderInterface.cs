using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Entities;
namespace ECommerceApi.Interfaces
{
    public interface OrderInterface
    {
        List<Order> GetAll();
        Order GetById(int id);
        void Add(Order Order);
    }
}