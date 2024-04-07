using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Batch : Product
    {
        public int Quantity { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine();
        }
    }
}
