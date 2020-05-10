using FactoryMethod.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class DefaultProduct : Product
    {
        public override string ShipFrom()
        {
            return "Not Available";
        }
    }
}
