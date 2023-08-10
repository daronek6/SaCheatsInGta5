using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class ItsAllBull : Cheat
    {
        private Model dozer;

        public ItsAllBull()
          : base(CheatType.Instant, "ItsAllBull", "Spawn Dozer")
        {
            this.dozer = new Model(VehicleHash.Bulldozer);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.dozer, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
