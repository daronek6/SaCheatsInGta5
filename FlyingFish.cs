using System;

namespace SaCheats
{
    internal class FlyingFish : Cheat
    {
        public FlyingFish()
          : base(CheatType.NotSupported, "FlyingFish", "Flying Boats")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
