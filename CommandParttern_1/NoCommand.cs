using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParttern_1
{
    public class NoCommand:Command
    {
        public void Execute()
        {
            
        }


        public void UnDo()
        {
            throw new NotImplementedException();
        }
    }
}
