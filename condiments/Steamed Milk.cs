using System;
using System.Collections.Generic;
using DecoratorPattern.Beverages;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Steamed_Milk : CondimentDecorator
    {
        public Steamed_Milk(Beverage beverage)
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
            return baseBeverage.GetDescription() + ", Steamed Milk";
        }
    }
}
