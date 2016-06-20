using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new NYStylePizzaStore();
            Pizza pizza = factory.OrderPizza("cheese");
            Console.WriteLine(pizza.getName());
            Console.ReadKey();
        }
    }
}
