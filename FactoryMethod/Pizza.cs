using System;
using System.Collections;


namespace FactoryMethod
{
   public abstract class Pizza
    {
        public  string Name;
        public  string Daugh;
        public  string Sauce;
        public ArrayList Toppins = new ArrayList();

        public virtual void prepare()
        {
            Console.WriteLine("Preparing"+Name);

            Console.WriteLine("Tossing dough...");

            Console.WriteLine("Adding sauce...");

            Console.WriteLine("Adding toppings:");

            for(int i=0;i<Toppins.Count;i++)
            {
                Console.WriteLine("   "+ Toppins[i].ToString());
            }
        }

      public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }     

        public virtual string getName()
        {
            return Name;
        }
    }
}
