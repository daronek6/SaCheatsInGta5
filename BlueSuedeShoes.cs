using System;

namespace SaCheats
{
    internal class BlueSuedeShoes : Cheat
    {
        public BlueSuedeShoes()
          : base(CheatType.NotSupported, "BlueSuedeShoes", "Everyone Is Elvis")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
