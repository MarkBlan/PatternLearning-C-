using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaSimpleFactory factory = new PizzaSimpleFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);
            Pizza pizza= pizzaStore.CreatePizza("cheeZ");
            Console.ReadKey();
        }
    }
}
