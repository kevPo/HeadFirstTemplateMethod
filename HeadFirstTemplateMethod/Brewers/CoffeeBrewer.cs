using System;

namespace HeadFirstTemplateMethod.Brewers
{
    public class CoffeeBrewer : IBrewer
    {
        public void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
