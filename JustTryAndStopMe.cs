using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class JustTryAndStopMe : Cheat
    {
        private Model racecar;

        public JustTryAndStopMe()
          : base(CheatType.Instant, "JustTryAndStopMe", "Spawn Racecar2")
        {
            this.racecar = new Model(VehicleHash.RapidGT);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.racecar, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
