using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
   public class Flock:Quackable
    {
       private ArrayList quackers = new ArrayList();

       public void Add(Quackable quacker)
       {
           quackers.Add(quacker);
       }

        public void Quack()
        {
            
        }
    }
}
