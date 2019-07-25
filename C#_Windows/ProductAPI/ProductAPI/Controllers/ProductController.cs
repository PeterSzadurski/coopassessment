using ProductAPI.DAL;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    /*
     Adding Routing:
     https://www.c-sharpcorner.com/article/crud-operation-using-web-api-and-angular-7/
         */
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        ProductContext entities = new ProductContext();
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {

            using (entities)
            {
                return entities.Products.ToList();
            }

        }
        [Route("GetProduct")]
        [HttpGet]
        public Product Get(int i)
        {
            using (entities)
            {
                try
                {
                    return entities.Products.Find(i);
                }
                catch
                {
                    return new Product { Name = "Invalid", Description = "Invalid", Price = 0 };
                }

            }
        }
        [Route("DeleteProduct")]
        [HttpGet]
        public void Delete(int i)
        {
            using (entities)
            {

                try
                {
                    Product deleted = entities.Products.Find(i);
                    entities.Products.ToList().Remove(deleted);
                    entities.SaveChanges();
                    Logger.Info(deleted.Name + " ID:"+ deleted.ProductID + "has been removed"  );
                }
                catch
                { }
            }
        }
        [Route("Edit")]
        [HttpPost]
        public void Edit(Product prod)
        {
            using (entities)
            {

                try
                {
                    int index = prod.ProductID;
                    entities.Products.Find(index).Name = prod.Name + "_editted";
                    entities.Products.Find(index).Description = prod.Description;
                    entities.Products.Find(index).Price = prod.Price;


                    entities.SaveChanges();
                }
                catch
                { }
            }

        }
        [Route("Add")]
        [HttpPost]
        public void Add(Product prod)
        {
            using (entities)
            {
                entities.Products.Add(prod);
                Logger.Info(prod.Name + " ID:" + prod.ProductID + "has been added");


            }
        }
    }
}

