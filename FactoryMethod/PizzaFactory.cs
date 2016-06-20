
namespace FactoryMethod
{
    public abstract class PizzaFactory
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
        public abstract Pizza CreatePizza(string type);
        
    }
}
