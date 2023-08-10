using System;

namespace SaCheats
{
    internal class LifesABeach : Cheat
    {
        public LifesABeach()
          : base(CheatType.NotSupported, "LifesABeach", "Beach Party Mode")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
