using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class TurkeyAdapter:Duck
    {
        private Turkey turkey_;

        public TurkeyAdapter(Turkey turkey)
        {
            turkey_ = turkey;
        }
        public void Quack()
        {
            turkey_.Gobble();
        }

        public void Fly()
        {
            for(int i=0;i<5;i++)
            {
                turkey_.Fly();
            }
        }
    }
}
