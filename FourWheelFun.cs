using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class FourWheelFun : Cheat
    {
        private Model quad;

        public FourWheelFun()
          : base(CheatType.Instant, "FourWheelFun", "Spawn Quad")
        {
            this.quad = new Model(VehicleHash.Blazer);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.quad, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
