using GTA;
using GTA.Math;
using System;

namespace SaCheats
{
    internal class OldSpeedDemon : Cheat
    {
        private Model old;

        public OldSpeedDemon()
          : base(CheatType.Instant, "OldSpeedDemon", "Spawn Bloodring Banger")
        {
            this.old = new Model(941800958);
        }

        public override void CheatActive(object o, EventArgs e) => World.CreateVehicle(this.old, ((Entity)Game.Player.Character).GetOffsetPosition(new Vector3(0.0f, 6f, 0.0f)));

        public override void Toggle() => base.Toggle();
    }
}
