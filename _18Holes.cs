using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class _18Holes : Cheat
    {
        private Model caddy;

        public _18Holes()
          : base(CheatType.Instant, "18Holes", "Spawn Caddy")
        {
            this.caddy = new Model(VehicleHash.Caddy);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.caddy, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
