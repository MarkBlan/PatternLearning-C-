using System;

namespace DesignPattern
{
    public class ModelDuck:Duck
    {
        public ModelDuck()
        {
            QuackBehvior = new GuaQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I Can display a ModelDuck");
        }
    }
}
