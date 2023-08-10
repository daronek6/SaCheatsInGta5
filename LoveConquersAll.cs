using System;

namespace SaCheats
{
    internal class LoveConquersAll : Cheat
    {
        public LoveConquersAll()
          : base(CheatType.NotSupported, "LoveConquersAll", "Women Talk to You (Gimp Suit, Hoes And Pimps Everywhere)")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
