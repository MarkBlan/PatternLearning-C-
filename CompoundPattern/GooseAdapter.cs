using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
   public class GooseAdapter:Quackable
    {
       private Goose goose_;

       public GooseAdapter(Goose goose)
       {
           goose_ = goose;
       }

        public void Quack()
        {
            goose_.Honk();
        }
    }
}
