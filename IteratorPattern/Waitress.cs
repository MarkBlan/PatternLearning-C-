using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public  class Waitress
    {
        private DinnerMenu dinnerMenu_;
        public Waitress(DinnerMenu dinnerMenu)
        {
            dinnerMenu_ = dinnerMenu;
        }

        public void PrintMenuItem()
        {
            DinnerMenuIterator dinnerIterator = (DinnerMenuIterator)dinnerMenu_.CreateIterator();
            Console.WriteLine("====================Breakfast Printed Below============\n");
            printMenuItem(dinnerIterator);
        }

        private void printMenuItem(Iterator iterator_)
        {
            while(iterator_.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator_.Next();
                Console.WriteLine("Name:"+menuItem.GetName()+"\n");
                Console.WriteLine("Description:" + menuItem.GetDescription() + "\n");
                Console.WriteLine("IsVegeterian:" + menuItem.IsVegerian() + "\n");
                Console.WriteLine("Price:" + menuItem.GetPrice() + "\n");
            }
        }
    }
}
