using GTA;
using System;

namespace SaCheats
{
    internal class PleasantlyWarm : Cheat
    {
        public PleasantlyWarm()
          : base(CheatType.Instant, "PleasantlyWarm", "Sunny Weather")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.Weather = (Weather)1;

        public override void Toggle() => base.Toggle();
    }
}
