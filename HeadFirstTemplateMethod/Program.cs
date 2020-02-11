using System;
using System.Collections.Generic;
using HeadFirstTemplateMethod.Brewers;
using HeadFirstTemplateMethod.Condiments;

namespace HeadFirstTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new CaffeineBeverage(new TeaBrewer(), new TeaCondiments());
            var coffee = new CaffeineBeverage(new CoffeeBrewer(), new CoffeeCondiments());
            var beverages = new List<CaffeineBeverage> { tea, coffee };

            beverages.ForEach(beverage => beverage.PrepareRecipe());

            Console.Read();
        }
    }
}
