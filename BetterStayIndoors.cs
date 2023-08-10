using System;

namespace SaCheats
{
    internal class BetterStayIndoors : Cheat
    {
        public BetterStayIndoors()
          : base(CheatType.NotSupported, "BetterStayIndoors", "Spawn Random Gang Groups")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
