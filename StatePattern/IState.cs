using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();

        void TurnCrank();

        void Dispense();
    }
    enum State
    {
        SOLD_OUT,
        NO_QUARTER,
        HAS_QUARTER,
        SOLD
    }
}
