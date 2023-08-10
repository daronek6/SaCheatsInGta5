using System;

namespace SaCheats
{
    internal class LeanAndMean : Cheat
    {
        public LeanAndMean()
          : base(CheatType.NotSupported, "LeanAndMean", "Skinny Player")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
