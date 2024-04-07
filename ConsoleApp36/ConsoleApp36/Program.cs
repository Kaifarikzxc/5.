using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
        {
            new AllProduct { Name = "Молоко", Price = 100 },
            new Batch { Name = "Яблоки", Price = 200, Quantity = 10 },
            new Kit
            {
                Name = "Подарочный набор",
                Price = 500,
                Products = new List<AllProduct>
                {
                    new AllProduct { Name = "Шоколад" },
                    new AllProduct { Name = "Печенье" }
                }
            }
        };
            foreach (var product in products)
            {
                product.DisplayInfo();
            }
        }
    }
}