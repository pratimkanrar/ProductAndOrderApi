using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ECommerceApi.Entities;
namespace ECommerceApi.Database
{
    public class ECommerceDBContext : DbContext
    {
        //Entity set
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ECommerce;Trusted_Connection=True;");
        }
    }
}