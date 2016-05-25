using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck blueDuck = new BlueDuck();
            blueDuck.Display();
            blueDuck.Fly();
            blueDuck.Quack();
            blueDuck.SetFlyBehavior(new FlyWithRocket());
            blueDuck.Fly();
            Console.ReadKey();
        }
    }
}
