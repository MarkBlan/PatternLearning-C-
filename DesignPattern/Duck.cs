using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("Every Duck Can Swim!");
        }

        public virtual void Display()
        {

        }

        public IFlyBehavior FlyBehavior
        {
            get; set;
        }

        public IQuackBehavior QuackBehvior
        {
            get; set;
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehvior = quackBehavior;
        }
        
        public void Fly()
        {
            FlyBehavior.Fly();
        }

        public void Quack()
        {
            QuackBehvior.Quack();
        }

    }
}
