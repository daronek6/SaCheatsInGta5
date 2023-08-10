using GTA;
using System;

namespace SaCheats
{
    internal class GoodbyeCruelWorld : Cheat
    {
        public GoodbyeCruelWorld()
          : base(CheatType.Instant, "GoodbyeCruelWorld", "Suicide")
        {
        }

        public override void CheatActive(object o, EventArgs e) => Game.Player.Character.Kill();

        public override void Toggle() => base.Toggle();
    }
}
