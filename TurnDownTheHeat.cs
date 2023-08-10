using GTA;
using System;

namespace SaCheats
{
    internal class TurnDownTheHeat : Cheat
    {
        public TurnDownTheHeat()
          : base(CheatType.Instant, "TurnDownTheHeat", "Clear Wanted Level")
        {
        }

        public override void CheatActive(object o, EventArgs e) => Game.Player.WantedLevel = 0;

        public override void Toggle() => base.Toggle();
    }
}
