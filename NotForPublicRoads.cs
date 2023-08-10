using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class NotForPublicRoads : Cheat
    {
        private Model racecar;

        public NotForPublicRoads()
          : base(CheatType.Instant, "NotForPublicRoads", "Spawn Racecar1")
        {
            this.racecar = new Model(VehicleHash.Turismor);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.racecar, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
