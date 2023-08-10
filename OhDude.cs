using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class OhDude : Cheat
    {
        private Model hunter;

        public OhDude()
          : base(CheatType.Instant, "OhDude", "Spawn Hunter")
        {
            this.hunter = new Model(VehicleHash.Hunter);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.hunter, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
