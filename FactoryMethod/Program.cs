using FactoryMethod.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            Product product;

            for (int month = 1; month < 12; month++)
            {
                product = c.FactoryMethod(month);
                Console.WriteLine("Coffee Beans: " + product.ShipFrom());
            }
            Console.ReadKey();
        }
    }
}
