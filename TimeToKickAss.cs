using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class TimeToKickAss : Cheat
    {
        private Model tank;

        public TimeToKickAss()
          : base(CheatType.Instant, "TimeToKickAss", "Spawn Rhino")
        {
            this.tank = new Model(VehicleHash.Rhino);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.tank, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
