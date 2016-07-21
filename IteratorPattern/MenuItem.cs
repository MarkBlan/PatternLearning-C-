using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
   public class MenuItem
    {
       private string name_;

       private string description_;

       private bool vegetarian_;

       private double price_;

       public MenuItem(string name,string description,bool isVegerian,double price)
       {
           name_ = name;
           description_ = description;
           vegetarian_ = isVegerian;
           price_ = price;
       }

       public string GetName()
       {
           return name_;
       }

       public string GetDescription()
       {
           return description_;
       }

       public bool IsVegerian()
       {
           return vegetarian_;
       }

       public double GetPrice()
       {
           return price_;
       }

    }
}
