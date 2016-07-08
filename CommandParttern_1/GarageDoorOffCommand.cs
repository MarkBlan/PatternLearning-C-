using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParttern_1
{
    public class GarageDoorOffCommand : Command
    {
        private GarageDoor garageDoor_;

        public GarageDoorOffCommand(GarageDoor garageDoor)
        {
            this.garageDoor_ = garageDoor;
        }
        public void Execute()
        {
            garageDoor_.Off();
        }

        public void UnDo()
        {
            garageDoor_.On();
        }
    }
}
