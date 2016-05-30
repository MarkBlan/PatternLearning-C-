using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoast:Beverage
    {

        public override double Cost()
        {
            return 10.0;
        }

        public DarkRoast(String description_)
        {
            Description = description_;
        }
        
    }
}
