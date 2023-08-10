using GTA;
using System;

namespace SaCheats
{
    internal class StayInAndWatchTV : Cheat
    {
        public StayInAndWatchTV()
          : base(CheatType.Instant, "StayInAndWatchTV", "Rainy Weather")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.Weather = (Weather)6;

        public override void Toggle() => base.Toggle();
    }
}
