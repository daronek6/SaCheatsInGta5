using System;

namespace SaCheats
{
    internal class ChittyChittyBangBang : Cheat
    {
        public ChittyChittyBangBang()
          : base(CheatType.NotSupported, "ChittyChittyBangBang", "Flying Cars")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
