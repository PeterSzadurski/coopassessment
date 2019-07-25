using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProductAPI.DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductsDBEF")
        {
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductContext,
           //     ProductAPI.Migrations.Configuration>("ProductsDBEF"));
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Product>().HasKey(i => i.ID);
        }

        //public virtual DbSet<Product> Products { get; set; }

    }
}