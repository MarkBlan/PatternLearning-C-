using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NYStylePizzaStore : PizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza=null;
            switch(type)
            {
                case "cheese":
                    pizza = new NYStyleCheezPizza();
                    break;
            }
            return pizza;
        }
    }
}
