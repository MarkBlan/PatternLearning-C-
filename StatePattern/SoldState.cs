using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
   public class SoldState:IState
    {
       private GumballMachine gumballMachine_;

       public SoldState(GumballMachine gumballMachine)
       {
           gumballMachine_ = gumballMachine;
       }
        public void InsertQuarter()
        {
            Console.WriteLine("Sorry ,Please wait until the Gumball out!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry ,you have Turned the Crane!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Sorry ,you have Turned the Crane!");
        }

        public void Dispense()
        {
            gumballMachine_.ReleaseBall();
            if(gumballMachine_.GetCount()>0)
            {
                gumballMachine_.SetState(gumballMachine_.GetNoQuarterState());
            }
            else
            {
                gumballMachine_.SetState(gumballMachine_.GetSoldOutState());
            }
        }
    }
}
