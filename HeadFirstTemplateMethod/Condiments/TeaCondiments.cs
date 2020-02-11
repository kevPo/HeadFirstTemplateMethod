using System;

namespace HeadFirstTemplateMethod.Condiments
{
    public class TeaCondiments : ICondiments
    {
        public void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
