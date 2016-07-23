using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class GumballMonitor
    {
        private GumballMachine gumballMachine_;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            gumballMachine_ = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine(gumballMachine_.GetLocation());
        }
    }
}
