using FactoryMethod.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class Product1 : Product
    {
        public override string ShipFrom()
        {
            return "From South Africa";
        }
    }
}
