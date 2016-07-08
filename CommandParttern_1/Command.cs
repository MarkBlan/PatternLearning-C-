using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParttern_1
{
   public interface Command
    {
       void Execute();

       void UnDo();

    }
}
