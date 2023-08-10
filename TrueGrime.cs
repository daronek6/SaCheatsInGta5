using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class TrueGrime : Cheat
    {
        private Model trashmaster;

        public TrueGrime()
          : base(CheatType.Instant, "TrueGrime", "Spawn Trashmaster")
        {
            this.trashmaster = new Model(VehicleHash.Trash);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.trashmaster, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
