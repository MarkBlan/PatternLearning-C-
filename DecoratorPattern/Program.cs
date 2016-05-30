using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage darkRoast = new DarkRoast("DarkRoast");
            Console.WriteLine("This the Beverage:{0}",darkRoast.GetDescription());
            Console.WriteLine("The Beverage{0}costs {1}", darkRoast.GetDescription(), darkRoast.Cost());
            Milk milk = new Milk(darkRoast);
            Console.WriteLine("This the Beverage:{0}", milk.GetDescription());
            Console.WriteLine("The Beverage{0}costs {1}", milk.GetDescription(), milk.Cost());
            Console.ReadKey();
        }
    }
}
