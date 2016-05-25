using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
   public interface Subject
    {
        void Register(Observer o);
        void Remove(Observer o);
        void Notify();
    }
}
