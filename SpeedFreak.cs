using System;

namespace SaCheats
{
    internal class SpeedFreak : Cheat
    {
        public SpeedFreak()
          : base(CheatType.NotSupported, "SpeedFreak", "All Cars Have Nitro")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
