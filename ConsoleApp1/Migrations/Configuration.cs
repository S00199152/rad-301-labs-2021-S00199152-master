namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApp1.BusinessContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConsoleApp1.BusinessContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            DateTime baseDate = DateTime.Parse("02/12/2019");
            Random r = new Random();

            context.Categories.AddOrUpdate(c => c.CategoryID, new Category[]
            {
                new Category { CategoryID = 1, Description = "Hardware"},
                new Category { CategoryID = 2, Description = "Electrical Appliances"},

            });
            context.SaveChanges();
            context.Products.AddOrUpdate(p => p.Description,
                new Product[]
                {
                    new Product
                    {
                        Description = "9 inch nails",
                        QuantityInStock = 10, UnitPrice = 100.5f,
                        dateFirstIssued = baseDate.AddDays(r.Next(5,15)),
                        CategoryID = 1
                    },
                //Other Products
                });
        }
    }
}
