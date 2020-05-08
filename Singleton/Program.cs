using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton MyInstance = Singleton.Instance();
            Singleton MyInstance_2 = Singleton.Instance();

            Console.ReadKey();
        }
    }
}
