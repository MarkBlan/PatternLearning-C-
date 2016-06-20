

namespace FactoryMethod
{
   public class NYStyleCheezPizza:Pizza
    {
        public NYStyleCheezPizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Daugh = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppins.Add("Grated Reggiano Cheese");
        }
    }
}
