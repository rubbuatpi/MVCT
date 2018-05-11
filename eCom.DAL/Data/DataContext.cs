using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using eCom.Model;
namespace eCom.DAL.Data
{
    public class DataContext:DbContext
    {
        public DataContext() : base("ConnectionString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Item> Order_Items { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
