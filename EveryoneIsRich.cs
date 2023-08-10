using System;

namespace SaCheats
{
    internal class EveryoneIsRich : Cheat
    {
        public EveryoneIsRich()
          : base(CheatType.NotSupported, "EveryoneIsRich", "All Expensive Cars")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
