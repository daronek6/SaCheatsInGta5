using GTA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    internal class RoughNeighbourhood : Cheat
    {
        private IEnumerable<WeaponHash> WeaponsList;
        private Random rand;
        private bool hasWeapon;
        private int index;
        private long frame;
        private long nextFrame;

        public RoughNeighbourhood()
          : base(CheatType.Active, "RoughNeighbourhood", "People Attack Each Other With Random Weapons")
        {
            this.WeaponsList = Enum.GetValues(typeof(WeaponHash)).Cast<WeaponHash>();
            this.WeaponsList = this.WeaponsList.Where<WeaponHash>((Func<WeaponHash, bool>)(v => v != WeaponHash.Unarmed));
            this.rand = new Random();
        }

        public override void CheatActive(object o, EventArgs e)
        {
            this.frame = Util.nanoTime();
            if (this.frame < this.nextFrame)
                return;
            Ped[] nearbyPeds = World.GetNearbyPeds(((Entity)Game.Player.Character).Position, 150f);
            foreach (Ped ped1 in nearbyPeds)
            {
                if (!ped1.IsPlayer)
                {
                    if (ped1.IsHuman)
                    {
                        this.hasWeapon = false;
                        for (this.index = 0; !this.hasWeapon && this.index < this.WeaponsList.Count<WeaponHash>(); ++this.index)
                        {
                            if (ped1.Weapons.HasWeapon(this.WeaponsList.ElementAt<WeaponHash>(this.index)))
                                this.hasWeapon = true;
                        }
                        if (!this.hasWeapon)
                        {
                            var weapon = this.RandomWeapon();
                            ped1.Weapons.Give(weapon, 1000, true, true);
                            ped1.Weapons.Select(weapon, true);
                        }

                    }
                    nearbyPeds = nearbyPeds.SkipWhile<Ped>((Func<Ped, bool>)(v => v == ped1)).ToArray<Ped>();
                    Ped ped2 = this.RandomPed(nearbyPeds);
                    ped1.RelationshipGroup.SetRelationshipBetweenGroups(ped2.RelationshipGroup, Relationship.Hate, true);
                }
            }
            this.nextFrame = this.frame + 3000000000L;
        }

        public override void Toggle()
        {
            base.Toggle();
            this.nextFrame = Util.nanoTime();
        }

        public WeaponHash RandomWeapon() => this.WeaponsList.ElementAt<WeaponHash>(this.rand.Next(0, this.WeaponsList.Count<WeaponHash>()));

        public Ped RandomPed(Ped[] peds) => peds[this.rand.Next(0, peds.Length)];
    }
}
