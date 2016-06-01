using System;


namespace SimpleFactory
{
   public  class PizzaSimpleFactory
    {
        public Pizza CreatePizza(String type)
        {
            switch(type.ToUpper())
            {
                case "CHEEZ":
                    return new CheezPizza();
                case "VEGGIE":
                    return new VeggiePizza();
                case "CLAM":
                    return new ClamPizza();
                case "Pepperoni":
                    return new PepperoniPizza();
                default:
                    return null;       
            }

        }

      
    }
}
