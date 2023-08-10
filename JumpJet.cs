using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class JumpJet : Cheat
    {
        private Model hydra;

        public JumpJet()
          : base(CheatType.Instant, "JumpJet", "Spawn Hydra")
        {
            this.hydra = new Model(VehicleHash.Hydra);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.hydra, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
