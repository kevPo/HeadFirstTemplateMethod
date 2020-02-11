using System;
using HeadFirstTemplateMethod.Brewers;
using HeadFirstTemplateMethod.Condiments;

namespace HeadFirstTemplateMethod
{
    public class CaffeineBeverage
    {
        private readonly IBrewer brewer;
        private readonly ICondiments condiments;

        public CaffeineBeverage(IBrewer brewer, ICondiments condiments)
        {
            this.brewer = brewer;
            this.condiments = condiments;
        }

        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void Brew()
        {
            brewer.Brew();
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected void AddCondiments()
        {
            condiments.AddCondiments();
        }
    }
}
