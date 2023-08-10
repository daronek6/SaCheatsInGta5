using System;

namespace SaCheats
{
    internal class Crazytown : Cheat
    {
        public Crazytown()
          : base(CheatType.NotSupported, "Crazytown", "Funhouse Mode")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
