using System;

namespace SaCheats
{
    internal class NoOneCanStopUs : Cheat
    {
        public NoOneCanStopUs()
          : base(CheatType.NotSupported, "NoOneCanStopUs", "Recruit anyone (AK-47)")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
