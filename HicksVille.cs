using System;

namespace SaCheats
{
    internal class HicksVille : Cheat
    {
        public HicksVille()
          : base(CheatType.NotSupported, "HicksVille", "Country Vehicles")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
