using System;

namespace SaCheats
{
    internal class NinjaTown : Cheat
    {
        public NinjaTown()
          : base(CheatType.NotSupported, "NinjaTown", "Ninja Theme (Katana, WuZies Gang, Black Color Of Service Vehicles, Bikes)")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
