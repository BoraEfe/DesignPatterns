using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate()
        {
            description = "Chocolate";
        }
        public override double cost()
        {
            return 3.0;
        }
    }
}
