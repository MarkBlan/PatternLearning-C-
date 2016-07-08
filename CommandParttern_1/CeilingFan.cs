using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParttern_1
{
   public class CeilingFan
    {
       public static const int HIGH = 3;

       public static const int MEDIUM = 2;

       public static const int LOW = 1;

       public static const int OFF = 0;

       string location_;

       int speed_;

       public CeilingFan(string location)
       {
           location_ = location;
           speed_ = OFF;
       }

       public void High()
       {
           speed_ = HIGH;
       }

       public void Medium()
       {
           speed_ = MEDIUM;
       }

       public void Low()
       {
           speed_ = LOW;
       }

       public void Off()
       {
           speed_ = OFF;
       }

       public int GetSpeed()
       {
           return speed_;
       }

    }
}
