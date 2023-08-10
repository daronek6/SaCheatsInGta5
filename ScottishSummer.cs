using GTA;
using System;

namespace SaCheats
{
    internal class ScottishSummer : Cheat
    {
        public ScottishSummer()
          : base(CheatType.Instant, "ScottishSummer", "Thunderstorm")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.Weather = (Weather)7;

        public override void Toggle() => base.Toggle();
    }
}
