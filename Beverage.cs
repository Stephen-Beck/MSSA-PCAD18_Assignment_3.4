using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._4
{
    public abstract class Beverage
    {
        public enum Container { Bottle, Can, Mug, Cup };

        public int BeverageID { get; set; }
        public string Name { get; set; }
        public DateTime ExpDate { get; set; }
        public Container BeverageContainer { get; set; }
        public string Manufacturer { get; set; }
        public double SizeInOz { get; set; }
        public string Flavor { get; set; }
        public double TemperatureInF { get; set; }
    }

    public class Coffee : Beverage
    {
        public enum Roast { Light, Medium, Dark };

        public Roast CoffeeRoast { get; set; }
        public bool IsDecaf { get; set; }
        public string TypeOfCoffee { get; set; }

        public static List<Coffee> PopulateCoffees()
        {
            return new List<Coffee>(){
                new Coffee() { BeverageID = 1, Name = "Espresso", ExpDate = new DateTime(2025,7,25), BeverageContainer = Beverage.Container.Cup, Manufacturer = "Café El Aguila", SizeInOz = 1, Flavor = "", TemperatureInF = 150, CoffeeRoast = Coffee.Roast.Dark, IsDecaf = false, TypeOfCoffee = "Espresso"},
                new Coffee() { BeverageID = 2, Name = "Iced Latte", ExpDate = new DateTime(2025,7,25), BeverageContainer = Beverage.Container.Mug, Manufacturer = "Dunkin'", SizeInOz = 16, Flavor = "Caramel", TemperatureInF = 40, CoffeeRoast = Coffee.Roast.Dark, IsDecaf = false, TypeOfCoffee = "Espresso"},
                new Coffee() { BeverageID = 3, Name = "Bottled Frappuccino", ExpDate = DateTime.Today.AddMonths(4), BeverageContainer = Beverage.Container.Bottle, Manufacturer = "Starbucks", SizeInOz = 13.7, Flavor = "Mocha", TemperatureInF = 40, CoffeeRoast = Coffee.Roast.Medium, IsDecaf = false, TypeOfCoffee = "Frappuccino"},
                new Coffee() { BeverageID = 4, Name = "Decaf Coffee", ExpDate = new DateTime(2025,7,25), BeverageContainer = Beverage.Container.Mug, Manufacturer = "Starbucks", SizeInOz = 16, Flavor = "Vanilla", TemperatureInF = 40, CoffeeRoast = Coffee.Roast.Light, IsDecaf = true, TypeOfCoffee = "Coffee"},
                new Coffee() { BeverageID = 5, Name = "Boss Coffee Flash Brew", ExpDate = DateTime.Today.AddMonths(8), BeverageContainer = Beverage.Container.Can, Manufacturer = "Suntory", SizeInOz = 6, Flavor = "", TemperatureInF = 40, CoffeeRoast = Coffee.Roast.Dark, IsDecaf = false, TypeOfCoffee = "Coffee"},
                new Coffee() { BeverageID = 6, Name = "UCC Caffe Latte", ExpDate = new DateTime(2026,2,5), BeverageContainer = Beverage.Container.Can, Manufacturer = "UCC", SizeInOz = 8.79, Flavor = "", TemperatureInF = 40, CoffeeRoast = Coffee.Roast.Medium, IsDecaf = false, TypeOfCoffee = "Espresso"},
                new Coffee() { BeverageID = 6, Name = "Georgia Coffee Original", ExpDate = DateTime.Today.AddMonths(7), BeverageContainer = Beverage.Container.Can, Manufacturer = "Coca-Cola", SizeInOz = 8.79, Flavor = "", TemperatureInF = 140, CoffeeRoast = Coffee.Roast.Light, IsDecaf = false, TypeOfCoffee = "Coffee"}
            };
        }
    }
}
