using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class MallardDuck:Duck
    {
        public void Quack()
        {
            Console.WriteLine("An MallardDuck Quack....");
        }

        public void Fly()
        {
            Console.WriteLine("An MallardDuck Fly....");
        }
    }
}
