using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public abstract class Character
    {
        public void Fight()
        {
            WeaponBehavior.GetWeapon();
        }

        public IWeaponBehavior WeaponBehavior { get; set; }

        public void SetWeaponBehavior(IWeaponBehavior weaponBehavior)
        {
            WeaponBehavior = weaponBehavior;
        }

    }
}
