using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class DoughnutHandicap : Cheat
    {
        private Model ranger;

        public DoughnutHandicap()
          : base(CheatType.Instant, "DoughnutHandicap", "Spawn Rancher")
        {
            this.ranger = new Model(VehicleHash.RancherXL);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.ranger, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
