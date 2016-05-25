using System;

namespace DesignPattern
{
    public class BlueDuck:Duck
    {
        public BlueDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehvior = new GuaQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a BlueDuck");
        }
    }
}
