using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
            Console.WriteLine("Instance is created..");
        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
                
            return instance;
        }
    }
}
