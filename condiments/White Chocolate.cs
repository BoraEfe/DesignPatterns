using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class White_Chocolate : CondimentDecorator
    {
        public White_Chocolate(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }
        public override double cost()
        {
            return 0.30 + baseBeverage.cost();
        }
        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", White Chocolate";
        }
    }
}
