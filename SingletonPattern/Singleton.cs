using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
   public class Singleton
    {
       private static Singleton  uniqueInstance = new Singleton();

       private Singleton(){}

       public static Singleton GetInstance()
       {
           return uniqueInstance;
       }
    }
}
