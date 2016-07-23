using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoQuarterState:IState
    {
        private GumballMachine gumballMachine_;

        public NoQuarterState(GumballMachine gumballMachine)
        {
           gumballMachine_ = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You Have Inserted a Quarter!");
            gumballMachine_.SetState(gumballMachine_.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You could not Enject a Quarter Before you have Inserted a Quarter!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You could not TurnCrank a Quarter Before you have Inserted a Quarter!");
        }

        public void Dispense()
        {
            Console.WriteLine("You have to Pay First!");
        }
    }
}
