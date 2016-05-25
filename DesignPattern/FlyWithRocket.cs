using System;

namespace DesignPattern
{
    public class FlyWithRocket : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly as fast as a Rocket");
        }
    }
}
