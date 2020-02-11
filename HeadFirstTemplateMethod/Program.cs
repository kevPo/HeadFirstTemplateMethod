using System;
using System.Collections.Generic;

namespace HeadFirstTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverages = new List<CaffeineBeverage> { new Tea(), new Coffee() };
            beverages.ForEach(beverage => beverage.PrepareRecipe());

            Console.Read();
        }
    }
}
