using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAPI.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
                new Product {Name = "Dog Shampoo", Price = 10.57, Description = "shampoo for long hair dogs" },
                new Product {Name = "WD Red 4 TB", Price = 150.99, Description = "NAS hard drive" },
                new Product {Name = "2018 Nissan Mourano", Price = 37866.99, Description = "Nissan Mourano AWD with Tech Package?" }
            };
            foreach (Product prod in products)
            {
                context.Products.Add(prod);
            }
            context.SaveChanges();
            
        }
    }
}