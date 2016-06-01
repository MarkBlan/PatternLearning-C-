using System;


namespace SimpleFactory
{
   public class PizzaStore
    {
        private PizzaSimpleFactory factory_;

        public PizzaStore(PizzaSimpleFactory factory)
        {
            factory_ = factory;
        }
        public Pizza CreatePizza(String type)
        {
            Pizza pizza;
            pizza = factory_.CreatePizza(type);
            if(pizza!=null)
            {
                pizza.Prepare();
                pizza.Bate();
                pizza.Cut();
                pizza.Box();
            }
            return pizza;
        }

    }
}
