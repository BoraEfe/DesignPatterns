using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Milk_Foam : CondimentDecorator
    {
        public Milk_Foam(Beverage Beverage)
        {
            this.baseBeverage = Beverage;
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
            return baseBeverage.GetDescription() + ", Milk Foam";
        }
    }
}
