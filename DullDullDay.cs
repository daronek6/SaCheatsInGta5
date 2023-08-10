using System;
using GTA;

namespace SaCheats
{
    class DullDullDay : Cheat
    {
        public DullDullDay() : base(CheatType.Instant, "DullDullDay", "Overcast Weather") { }

        public override void CheatActive(object o, EventArgs e)
        {
            World.Weather = Weather.Overcast;
        }
    }
}
