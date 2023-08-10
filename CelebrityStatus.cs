using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class CelebrityStatus : Cheat
    {
        private Model stretch;

        public CelebrityStatus()
          : base(CheatType.Instant, "CelebrityStatus", "Spawn Stretch")
        {
            this.stretch = new Model(VehicleHash.Stretch);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.stretch, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
