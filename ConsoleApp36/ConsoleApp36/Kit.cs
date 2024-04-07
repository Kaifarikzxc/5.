using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Kit : Product
    {
        public List<AllProduct> Products { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine("Продукты:");
            foreach (var product in Products)
            {
                Console.WriteLine($"  - {product.Name}");
            }
            Console.WriteLine();
        }
    }
}
