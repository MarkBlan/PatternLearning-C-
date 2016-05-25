using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SwordWeaponBehavior : IWeaponBehavior
    {
        public void GetWeapon()
        {
            Console.WriteLine("I will fight with a Sword!");
        }
    }
}
