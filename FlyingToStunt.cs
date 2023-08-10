using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class FlyingToStunt : Cheat
    {
        private Model stunt;

        public FlyingToStunt()
          : base(CheatType.Instant, "FlyingToStunt", "Spawn Stunt Plane")
        {
            this.stunt = new Model(VehicleHash.Stunt);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.stunt, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
