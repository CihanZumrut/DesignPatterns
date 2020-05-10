using FactoryMethod.Abstraction;
using FactoryMethod.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creator
    {
        public Product FactoryMethod(int month)
        {
            if (month >= 4 && month <= 11)
            {
                return new Product1();
            }
            else
            {
                if (month == 1 || month == 2 || month == 12)
                {
                    return new Product2();
                }
                else
                {
                    return new DefaultProduct();
                }
            }
        }
    }
}
