using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
   public class HasQuarterState:IState
    {
       private GumballMachine gumballMachine_;
       Random winnerRandom_ = new Random();
       public HasQuarterState(GumballMachine gumballMachine)
       {
           gumballMachine_ = gumballMachine;
       }

        public void InsertQuarter()
        {
            Console.WriteLine("You can not Insert a Quarter!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Enject a Quarter.");
            gumballMachine_.SetState(gumballMachine_.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You Have Turned the Crane.....");
            int win = winnerRandom_.Next(10);
            if((win==0)||(gumballMachine_.GetCount()>0))
            {
                gumballMachine_.SetState(gumballMachine_.GetWinnerState());
            }
            else
            {
                gumballMachine_.SetState(gumballMachine_.GetSoldState());
            }     
        }

        public void Dispense()
        {
            Console.WriteLine("No Gumball dispensed!");
        }
    }
}
