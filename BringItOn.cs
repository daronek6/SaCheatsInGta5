using GTA;
using System;

namespace SaCheats
{
    internal class BringItOn : Cheat
    {
        public BringItOn()
          : base(CheatType.Instant, "BringItOn", "Gives Five Stars Wanted Level")
        {
        }

        public override void CheatActive(object o, EventArgs e) => Game.Player.WantedLevel = 6;

        public override void Toggle() => base.Toggle();
    }
}
