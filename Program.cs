using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory factory = new();

            Beverage espresso = factory.createBeverage(DrinkType.Espresso, Size.TALL);
            Beverage doppio = factory.createBeverage(DrinkType.Doppio, Size.GRANDE);
            Beverage lungo = factory.createBeverage(DrinkType.Lungo, Size.VENDI);
            Beverage macchiato = factory.createBeverage(DrinkType.Macchiato, Size.TALL);
            Beverage corretta = factory.createBeverage(DrinkType.Corretta, Size.VENDI);
            Beverage conPanna = factory.createBeverage(DrinkType.ConPanna, Size.GRANDE);
            Beverage cappuccino = factory.createBeverage(DrinkType.Cappuccino, Size.VENDI);
            Beverage americano = factory.createBeverage(DrinkType.Americano, Size.TALL);
            Beverage caffeLatte = factory.createBeverage(DrinkType.CaffeLatte, Size.GRANDE);
            Beverage flatWhite = factory.createBeverage(DrinkType.FlatWhite, Size.TALL);
            Beverage romana = factory.createBeverage(DrinkType.Romana, Size.VENDI);
            Beverage marocchino = factory.createBeverage(DrinkType.Marocchino, Size.GRANDE);
            Beverage mocha = factory.createBeverage(DrinkType.Mocha, Size.TALL);
            Beverage bicerin = factory.createBeverage(DrinkType.Bicerin, Size.VENDI);
            Beverage breve = factory.createBeverage(DrinkType.Breve, Size.GRANDE);
            Beverage rafCoffee = factory.createBeverage(DrinkType.RafCoffee, Size.VENDI);
            Beverage meadRaf = factory.createBeverage(DrinkType.MeadRaf, Size.TALL);
            Beverage galao = factory.createBeverage(DrinkType.Galao, Size.GRANDE);
            Beverage caffeAffogato = factory.createBeverage(DrinkType.CaffeAffogato, Size.VENDI);
            Beverage viennaCoffee = factory.createBeverage(DrinkType.ViennaCoffee, Size.TALL);
            Beverage glace = factory.createBeverage(DrinkType.Glace, Size.GRANDE);
            Beverage chocolateMilk = factory.createBeverage(DrinkType.ChocolateMilk, Size.VENDI);
            Beverage demiCreme = factory.createBeverage(DrinkType.DemiCreme, Size.GRANDE);
            Beverage latteMacchiato = factory.createBeverage(DrinkType.LatteMacchiato, Size.TALL);
            Beverage freddo = factory.createBeverage(DrinkType.Freddo, Size.VENDI);
            Beverage frappuccino = factory.createBeverage(DrinkType.Frappuccino, Size.GRANDE);
            Beverage caramelFrappuccino = factory.createBeverage(DrinkType.CaramelFrappuccino, Size.TALL);
            Beverage frappe = factory.createBeverage(DrinkType.Frappe, Size.VENDI);
            Beverage irishCoffee = factory.createBeverage(DrinkType.IrishCoffee, Size.GRANDE);

        }
    }
}