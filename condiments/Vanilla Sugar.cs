using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Beverages;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Vanilla_Sugar : CondimentDecorator
    {
        public Vanilla_Sugar(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }
        public override double cost()
        {
            double extra = 0.10;
            switch (baseBeverage.Size)
            {
                case Size.GRANDE:
                    extra = 0.20;
                    break;
                case Size.VENDI:
                    extra = 0.30;
                    break;
            }
            return extra + baseBeverage.cost();
        }
        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Vanilla Sugar";
        }
    }
}
