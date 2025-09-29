using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class BeverageFactory
    {
        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " " + beverage.size + " $ " + beverage.cost().ToString("#.##"));
        }
        public Beverage createBeverage(DrinkType type, Size size)
        {
            Beverage beverage;

            switch (type)
            {
                case DrinkType.Espresso:
                    beverage = new Espresso();
                    break;
                case DrinkType.Doppio:
                    beverage = new Espresso();
                    beverage = new EspressoCondiment(beverage);
                    break;
                case DrinkType.Lungo:
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    break;
                case DrinkType.Macchiato:
                    beverage = new Espresso();
                    beverage = new Milk_Foam(beverage);
                    break;

                case DrinkType.Corretta:
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    break;

                case DrinkType.ConPanna:
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Cappuccino:
                    beverage = new Espresso();
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Milk_Foam(beverage);
                    break;

                case DrinkType.Americano:
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;

                case DrinkType.CaffeLatte:
                    beverage = new Espresso();
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Milk_Foam(beverage);
                    break;

                case DrinkType.FlatWhite:
                    beverage = new Espresso();
                    beverage = new EspressoCondiment(beverage);
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Milk_Foam(beverage);
                    break;

                case DrinkType.Romana:
                    beverage = new Espresso();
                    beverage = new Lemon(beverage);
                    break;

                case DrinkType.Marocchino:
                    beverage = new Espresso();
                    beverage = new ChocolateCondiment(beverage);
                    beverage = new Milk_Foam(beverage);
                    break;

                case DrinkType.Mocha:
                    beverage = new Espresso();
                    beverage = new ChocolateCondiment(beverage);
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Bicerin:
                    beverage = new Espresso();
                    beverage = new ChocolateCondiment(beverage);
                    beverage = new White_Chocolate(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Breve:
                    beverage = new Espresso();
                    beverage = new Milk_Foam(beverage);
                    beverage = new Steamed_Milk(beverage);
                    break;

                case DrinkType.RafCoffee:
                    beverage = new Espresso();
                    beverage = new Cream(beverage);
                    beverage = new Vanilla_Sugar(beverage);
                    break;

                case DrinkType.MeadRaf:
                    beverage = new Espresso();
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;

                case DrinkType.Galao:
                    beverage = new Espresso();
                    beverage = new Milk_Foam(beverage);
                    beverage = new Milk_Foam(beverage);
                    break;

                case DrinkType.CaffeAffogato:
                    beverage = new Espresso();
                    beverage = new EspressoCondiment(beverage);
                    beverage = new Ice_Cream(beverage);
                    break;

                case DrinkType.ViennaCoffee:
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    beverage = new EspressoCondiment(beverage);
                    break;

                case DrinkType.Glace:
                    beverage = new Espresso();
                    beverage = new Ice_Cream(beverage);
                    break;

                case DrinkType.ChocolateMilk:
                    beverage = new Chocolate();
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;

                case DrinkType.DemiCreme:
                    beverage = new Espresso();
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    beverage = new EspressoCondiment(beverage);
                    break;

                case DrinkType.LatteMacchiato:
                    beverage = new Espresso();
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Milk_Foam(beverage);
                    break;

                case DrinkType.Freddo:
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    beverage = new Ice_Cream(beverage);
                    break;

                case DrinkType.Frappuccino:
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.CaramelFrappuccino:
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;

                case DrinkType.Frappe:
                    beverage = new Espresso();
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Steamed_Milk(beverage);
                    beverage = new Ice_Cream(beverage);
                    break;

                case DrinkType.IrishCoffee:
                    beverage = new Espresso();
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    beverage = new EspressoCondiment(beverage);
                    break;

                default:
                    throw new ArgumentException("Invalid drink type");
            }
            beverage.size = size;
            PrintBeverage(beverage);

            return beverage;
        }
    }
}
