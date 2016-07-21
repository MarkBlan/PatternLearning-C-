using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class DinnerMenu
    {
        static int MAX_ITEMS = 6;

        private int numberOfItems = 0;

        private  MenuItem[] menuItems_;

        public DinnerMenu(MenuItem[] menuItems)
        {
            menuItems_ = menuItems;
        }

        public Iterator CreateIterator()
        {
            return new DinnerMenuIterator(menuItems_);
        }
    }

}
