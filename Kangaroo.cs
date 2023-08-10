using GTA;
using System;

namespace SaCheats
{
    internal class Kangaroo : Cheat
    {
        public Kangaroo()
          : base(CheatType.Active, "Kangaroo", "Mega Jump")
        {
        }

        public override void CheatActive(object o, EventArgs e) => Game.Player.SetSuperJumpThisFrame();

        public override void Toggle() => base.Toggle();
    }
}
