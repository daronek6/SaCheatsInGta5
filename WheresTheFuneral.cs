using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class WheresTheFuneral : Cheat
    {
        private Model romero;

        public WheresTheFuneral()
          : base(CheatType.Instant, "WheresTheFuneral", "Spawn Romero")
        {
            this.romero = new Model(VehicleHash.Romero);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.romero, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
