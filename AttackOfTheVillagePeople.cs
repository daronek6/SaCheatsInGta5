using GTA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    internal class AttackOfTheVillagePeople : Cheat
    {
        private IEnumerable<WeaponHash> WeaponsList;
        private Random rand;
        private bool hasWeapon;
        private int index;
        private long frame;
        private long prevFrame;

        public AttackOfTheVillagePeople()
          : base(CheatType.Active, "AttackOfTheVillagePeople", "People Attack You With Random Weapons")
        {
            this.WeaponsList = Enum.GetValues(typeof(WeaponHash)).Cast<WeaponHash>();
            this.WeaponsList = this.WeaponsList.Where<WeaponHash>((Func<WeaponHash, bool>)(v => v != WeaponHash.Unarmed));
            this.rand = new Random();
        }

        public override void CheatActive(object o, EventArgs e)
        {
            this.frame = Util.nanoTime();
            if (frame - prevFrame < 3000000000L)
                return;
            foreach (Ped nearbyPed in World.GetNearbyPeds((Game.Player.Character).Position, 120f))
            {
                if (!nearbyPed.IsPlayer)
                {
                    if (nearbyPed.IsHuman)
                    {
                        this.hasWeapon = false;
                        for (this.index = 0; !this.hasWeapon && this.index < this.WeaponsList.Count<WeaponHash>(); ++this.index)
                        {
                            if (nearbyPed.Weapons.HasWeapon(this.WeaponsList.ElementAt<WeaponHash>(this.index)))
                                this.hasWeapon = true;
                        }
                        if (!this.hasWeapon)
                        {
                            var weapon = this.RandomWeapon();
                            nearbyPed.Weapons.Give(weapon, 1000, true, true);
                            nearbyPed.Weapons.Select(weapon, true);
                        }
                    }
                    nearbyPed.RelationshipGroup.SetRelationshipBetweenGroups(Game.Player.Character.RelationshipGroup, Relationship.Hate, true);
                }
            }
            this.prevFrame = this.frame;
        }

        public override void Toggle()
        {
            base.Toggle();
            this.prevFrame = Util.nanoTime();
        }

        public WeaponHash RandomWeapon() => this.WeaponsList.ElementAt<WeaponHash>(this.rand.Next(0, this.WeaponsList.Count<WeaponHash>()));
    }
}
