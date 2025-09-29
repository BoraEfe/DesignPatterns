using System;
using System.Collections.Generic;
using System.Linq;
using DecoratorPattern.Beverages;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Liqour : CondimentDecorator
    {
        public Liqour(Beverage beverage)
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
            return baseBeverage.GetDescription() + ", Liqour";
        }
    }
}
