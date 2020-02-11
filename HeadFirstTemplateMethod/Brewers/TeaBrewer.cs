using System;

namespace HeadFirstTemplateMethod.Brewers
{
    public class TeaBrewer : IBrewer
    {
        public void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
