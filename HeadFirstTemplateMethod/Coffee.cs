﻿using System;

namespace HeadFirstTemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
