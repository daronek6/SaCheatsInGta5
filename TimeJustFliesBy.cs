using System;

namespace SaCheats
{
    internal class TimeJustFliesBy : Cheat
    {
        public TimeJustFliesBy()
          : base(CheatType.NotSupported, "TimeJustFliesBy", "Faster Clock")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
