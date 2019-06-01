using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ProductsDbSeeder
    {

        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Milka",
                    Description = "Milk",
                    Category = "Chocolate",
                    Price = 15
                },
                new Product
                {
                    Name = "Kinder",
                    Description = "Bueno",
                    Category = "Chocolate",
                    Price = 12
                }
            );
            context.SaveChanges();
        }
    }
}
