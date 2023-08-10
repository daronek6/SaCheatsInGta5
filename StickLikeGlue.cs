using System;

namespace SaCheats
{
    internal class StickLikeGlue : Cheat
    {
        public StickLikeGlue()
          : base(CheatType.NotSupported, "StickLikeGlue", "Modified Vehicle Handling")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
