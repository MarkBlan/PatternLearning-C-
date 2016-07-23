using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class WinnerState:IState
    {
        private GumballMachine gumballMachine_;

        public WinnerState(GumballMachine gumballMachine)
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
        }

        public void Dispense()
        {
            gumballMachine_.ReleaseBall();
            if(gumballMachine_.GetCount()==0)
            {
                gumballMachine_.SetState(gumballMachine_.GetSoldOutState());
            }
            else
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
}
