using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class IWantToHover : Cheat
    {
        private Model vortex;

        public IWantToHover()
          : base(CheatType.Instant, "IWantToHover", "Spawn Vortex Hovercraft")
        {
            this.vortex = new Model(VehicleHash.Vortex);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.vortex, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
