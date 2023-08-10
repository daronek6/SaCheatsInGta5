using GTA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    internal class SurroundedByNutters : Cheat
    {
        private IEnumerable<WeaponHash> WeaponsList;
        private Random rand;
        private bool hasWeapon;
        private int index;
        private long frame;
        private long nextFrame;

        public SurroundedByNutters()
          : base(CheatType.Active, "SurroundedByNutters", "Every Ped Gets Weapon")
        {
            this.WeaponsList = Enum.GetValues(typeof(WeaponHash)).Cast<WeaponHash>();
            //this.WeaponsList = this.WeaponsList.Where<WeaponHash>((Func<WeaponHash, bool>) (v => v != -1569615261));
            this.rand = new Random();
        }

        public override void CheatActive(object o, EventArgs e)
        {
            this.frame = Util.nanoTime();
            if (this.frame < this.nextFrame)
                return;
            foreach (Ped nearbyPed in World.GetNearbyPeds(((Entity)Game.Player.Character).Position, 100f))
            {
                if (!nearbyPed.IsPlayer)
                {
                    this.hasWeapon = false;
                    for (this.index = 0; !this.hasWeapon && this.index < this.WeaponsList.Count<WeaponHash>(); ++this.index)
                    {
                        if (nearbyPed.Weapons.HasWeapon(this.WeaponsList.ElementAt<WeaponHash>(this.index)))
                            this.hasWeapon = true;
                    }
                    if (!this.hasWeapon)
                        nearbyPed.Weapons.Give(this.RandomWeapon(), 1000, true, true);
                }
            }
            this.nextFrame = this.frame;
        }

        public override void Toggle()
        {
            base.Toggle();
            this.nextFrame = Util.nanoTime() + 3000000000L;
        }

        public WeaponHash RandomWeapon() => this.WeaponsList.ElementAt<WeaponHash>(this.rand.Next(0, this.WeaponsList.Count<WeaponHash>()));
    }
}
