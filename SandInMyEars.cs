using GTA;
using System;

namespace SaCheats
{
    internal class SandInMyEars : Cheat
    {
        public SandInMyEars()
          : base(CheatType.Instant, "SandInMyEars", "Sandstorm")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.Weather = Weather.Halloween;

        public override void Toggle() => base.Toggle();
    }
}
