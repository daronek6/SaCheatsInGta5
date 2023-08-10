using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class MonsterMash : Cheat
    {
        private Model monster;

        public MonsterMash()
          : base(CheatType.Instant, "MonsterMash", "Spawn Monster Truck")
        {
            this.monster = new Model(VehicleHash.Monster);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.monster, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
