using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParttern_1
{
    public class GarageDoorOnCommand:Command
    {
        private GarageDoor garageDoor_;

        public GarageDoorOnCommand(GarageDoor garageDoor)
        {
            this.garageDoor_ = garageDoor;
        }

        public void Execute()
        {
            garageDoor_.On();
        }

        public void UnDo()
        {
            garageDoor_.Off();
        }
    }
}
