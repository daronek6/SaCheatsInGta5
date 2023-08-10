using GTA;
using System;

namespace SaCheats
{
    internal class NightProwler : Cheat
    {
        public NightProwler()
          : base(CheatType.Active, "NightProwler", "Always Midnight")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.CurrentTimeOfDay = TimeSpan.Zero;

        public override void Toggle() => base.Toggle();
    }
}
