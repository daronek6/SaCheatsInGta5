using GTA;
using System;
using System.Collections.Generic;

namespace SaCheats
{
    internal class FullClip : Cheat
    {
        private HashSet<Weapon> weapons = new HashSet<Weapon>();

        public FullClip()
          : base(CheatType.Active, "FullClip", "Infinite Ammo, No Reloading")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            Game.Player.Character.Weapons.Current.InfiniteAmmoClip = true;
            this.weapons.Add(Game.Player.Character.Weapons.Current);
        }

        public override void Toggle()
        {
            base.Toggle();
            if (this.Toggled)
                return;
            foreach (Weapon weapon in this.weapons)
                weapon.InfiniteAmmoClip = false;
            this.weapons.Clear();
        }
    }
}
