using System;

namespace SaCheats
{
    internal class RocketMayhem : Cheat
    {
        public RocketMayhem()
          : base(CheatType.NotSupported, "RocketMayhem", "Recruit Anyone (Gets Rocket Launcher")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
