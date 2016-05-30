using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public  class Milk:Decorator
    {
        private Beverage component_;

        public Beverage Component
        {
            get
            {
                return component_;
            }
            set
            {
                component_ = value;
            }
        }

        public override double Cost()
        {
            return 0.5 + component_.Cost();
        }

        public override string GetDescription()
        {
            return component_.GetDescription() + ",milk";
        }

        public Milk(Beverage component)
        {
            component_ = component;
        }  
    }
}
