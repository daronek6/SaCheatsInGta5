using GTA;
using System;

namespace SaCheats
{
    internal class CantSeeWhereImGoing : Cheat
    {
        public CantSeeWhereImGoing()
          : base(CheatType.Instant, "CantSeeWhereImGoing", "Foggy Weather")
        {
        }

        public override void CheatActive(object o, EventArgs e) => World.Weather = (Weather)4;

        public override void Toggle() => base.Toggle();
    }
}
