using System;

namespace FactoryMethod
{
   public class ChicagoStyleCheesePizza:Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Daugh = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppins.Add("Grated Reggiano Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }

    }
}
