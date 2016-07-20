using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class CoffeineBeverage
    {
        public void BoulWater()
        {
            Console.WriteLine("Boul The Water.");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pour the Bervage In Cup.");
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public abstract Boolean CustomerWantsCondiments()
        {
            return true;
        }

        public  void PrepareRecipe()
        {
            BoulWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }
    }
}
