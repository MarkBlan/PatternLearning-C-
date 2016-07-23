using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    /// <summary>
    /// 装饰者模式
    /// </summary>
   public class QuackCounter:Quackable
    {
       private Quackable quackable_;

       private int numberOfQuacks;

       public QuackCounter(Quackable quackable)
       {
           quackable_ = quackable;
       }
        public void Quack()
        {
            quackable_.Quack();
            numberOfQuacks++;
        }

       public int GetQuacks()
        {
            return numberOfQuacks;
        }
    }
}
