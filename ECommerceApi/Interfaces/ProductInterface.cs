using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Entities;
namespace ECommerceApi.Interfaces
{
    public interface ProductInterface
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product Product);
        void Delete(int id);
        void Edit(Product Product);
    }
}