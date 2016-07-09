using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class WildTurkey:Turkey
    {
        public void Gobble()
        {
            Console.WriteLine("An WildTurkey Quack....");
        }

        public void Fly()
        {
            Console.WriteLine("An WildTurkey Fly....");
        }
    }
}
