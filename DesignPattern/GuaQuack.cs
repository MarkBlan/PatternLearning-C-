using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class GuaQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack like Gau.Gua.Gua...");
        }
    }
}
