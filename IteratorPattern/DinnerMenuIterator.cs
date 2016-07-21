using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
   public class DinnerMenuIterator:Iterator
    {
       private MenuItem[] menuItems_;

       private Byte position_;
       public DinnerMenuIterator(MenuItem[] menuItems)
       {
           menuItems_ = menuItems;
           position_ = 0;
       }
        public bool HasNext()
        {
            if (position_ >= menuItems_.Length || menuItems_[position_] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            MenuItem menuItem = menuItems_[position_];
            position_++;
            return menuItem;
        }
    }
}
