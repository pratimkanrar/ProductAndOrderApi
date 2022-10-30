using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApi.Entities;
using ECommerceApi.Interfaces;
using ECommerceApi.Database;
namespace ECommerceApi.Services
{
    public class ProductService : ProductInterface
    {
        private readonly ECommerceDBContext context;
        public ProductService()
        {
            this.context = new ECommerceDBContext();
        }
        public void Add(Product Product)
        {
            context.Products.Add(Product);
            context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public Product GetById(int id)
        {
            Product Product = context.Products.SingleOrDefault(i => i.ProductId == id);
            return Product;
        }
        public void Delete(int id)
        {
            Product Product = context.Products.SingleOrDefault(i => i.ProductId == id);
            context.Products.Remove(Product);
            context.SaveChanges();
        }
        public void Edit(Product Product)
        {
            context.Products.Update(Product);
            context.SaveChanges();
        }
    }
}