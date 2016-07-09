using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
   public class Singleton_lock
    {
       private static Object lockObj = new Object();

       private static Singleton_lock uniqueInstance;

       private Singleton_lock()
       {

       }

       public static Singleton_lock GetInstance()
       {
           lock(lockObj)
           {
               if(uniqueInstance == null)
               {
                   uniqueInstance = new Singleton_lock();
               }
               return uniqueInstance;
           }
       }

    }
}
