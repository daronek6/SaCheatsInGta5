using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class HitTheRoadJack : Cheat
    {
        private Model packer;
        private Model tanker;
        private Vehicle packerVeh;
        private Vehicle tankerVeh;

        public HitTheRoadJack()
          : base(CheatType.Instant, "HitTheRoadJack", "Spawn Tanker Truck")
        {
            this.packer = new Model(VehicleHash.Packer);
            this.tanker = new Model(VehicleHash.Tanker);
        }

        public override void CheatActive(object o, EventArgs e)
        {
            this.packerVeh = World.CreateVehicle(this.packer, Game.Player.Character.GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));
            this.tankerVeh = World.CreateVehicle(this.tanker, this.packerVeh.GetOffsetPosition(new Vector3(0.0f, -7.5f, 0.0f)));
        }

        public override void Toggle() => base.Toggle();
    }
}
