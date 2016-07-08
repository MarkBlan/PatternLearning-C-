using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParttern_1
{
    public class GarageDoor : ApplianceControl
    {

        private string garageDoor_;

        public GarageDoor(string garageDoor)
        {
            garageDoor_ = garageDoor;
        }
        public void On()
        {
            Console.WriteLine(String .Format("Open the {0}!",garageDoor_));
        }

        public void Off()
        {
            Console.WriteLine(String.Format("Close the {0}!", garageDoor_));
        }

    }
}
