using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
   public class GumballMachine
    {
       private IState state_;
       private int count_;
       private string location_;

       private IState hasQuarterState_;
       private IState noQuarterState_;
       private IState soldOutState_;
       private IState soldState_;
       private IState winnerState_;

       public GumballMachine(string location,int count)
       {
           hasQuarterState_ = new HasQuarterState(this);
           noQuarterState_ = new NoQuarterState(this);
           soldOutState_ = new SoldOutState(this);
           soldState_ = new SoldState(this);
           winnerState_ = new WinnerState(this);
           count_ = count;
           location_ = location;
           if(count>0)
           {
               state_ = noQuarterState_;
           }
       }

       public void InsertQuarter()
       {
           state_.InsertQuarter();
       }

       public void EjectQuarter()
       {
           state_.EjectQuarter();
       }

       public void TurnCrank()
       {
           state_.TurnCrank();
           state_.Dispense();
       }

       public void SetState(IState state)
       {
           state_ = state;
       }

       public void ReleaseBall()
       {
           Console.WriteLine("We will Release the Ball Now.");
           if(count_>0)
           {
               count_--;
           }
       }

       public IState GetHasQuarterState()
       {
           return hasQuarterState_;
       }

       public IState GetNoQuarterState()
       {
           return noQuarterState_;
       }

       public IState GetSoldOutState()
       {
           return soldOutState_;
       }

       public IState GetSoldState()
       {
           return soldState_;
       }

       public IState GetWinnerState()
       {
           return winnerState_;
       }

       public int GetCount()
       {
           return count_;
       }

       public IState GetState()
       {
           return state_;
       }

       public string GetLocation()
       {
           return location_;
       }
    }
}
