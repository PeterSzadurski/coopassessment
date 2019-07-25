namespace ProductAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductAPI.DAL.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = AutomaticMigrationsEnabled;
            ContextKey = "ProductAPI.DAL.ProductContext";
        }

        protected override void Seed(ProductAPI.DAL.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
