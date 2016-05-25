using System;


namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character queen = new Queen();
            queen.Fight();
            Console.ReadKey();
        }
    }
}
