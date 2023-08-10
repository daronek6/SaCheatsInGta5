using GTA;
using System;

namespace SaCheats
{
    internal class TurnUpTheHeat : Cheat
    {
        public TurnUpTheHeat()
          : base(CheatType.Instant, "TurnUpTheHeat", "Increase Wanted Level +2")
        {
        }

        public override void CheatActive(object o, EventArgs e) => Game.Player.WantedLevel += 2;

        public override void Toggle() => base.Toggle();
    }
}
