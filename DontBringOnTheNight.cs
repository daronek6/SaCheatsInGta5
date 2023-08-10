using GTA;
using System;

namespace SaCheats
{
    internal class DontBringOnTheNight : Cheat
    {
        public DontBringOnTheNight()
          : base(CheatType.Instant, "DontBringOnTheNight", "Orange Sky")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.Weather = (Weather)14;

        public override void Toggle() => base.Toggle();
    }
}
