using System;

namespace HeadFirstTemplateMethod.Condiments
{
    public class CoffeeCondiments : ICondiments
    {
        public void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
