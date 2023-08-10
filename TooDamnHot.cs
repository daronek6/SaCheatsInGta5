using GTA;
using System;

namespace SaCheats
{
    internal class TooDamnHot : Cheat
    {
        public TooDamnHot()
          : base(CheatType.Instant, "TooDamnHot", "Very Sunny Weather")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.Weather = (Weather)0;

        public override void Toggle() => base.Toggle();
    }
}
