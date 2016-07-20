using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Coffee:CoffeineBeverage
    {

        private Boolean customerWantsCondiments_;

        private String name_;

        public String Name
        {
            get
            {
                return name_;
            }
            set
            {
                name_ = value;
            }
        }

        public Coffee(String name, Boolean customerWantsCondiments)
        {
            name_ = name;
            customerWantsCondiments_ = customerWantsCondiments;
        }
        public override void Brew()
        {
            Console.WriteLine("Brew  the {0}", name_);
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add the Sugar and milk in the {0}", name_);
        }

        public override bool CustomerWantsCondiments()
        {
            if (customerWantsCondiments_)
                return true;
            else
                return false;
        }
    }
}
