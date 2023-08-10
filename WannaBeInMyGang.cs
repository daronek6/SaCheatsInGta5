using System;

namespace SaCheats
{
    internal class WannaBeInMyGang : Cheat
    {
        public WannaBeInMyGang()
          : base(CheatType.NotSupported, "WannaBeInMyGang", "Recruit Anyone (Gets Pistol)")
        {
        }

        public override void CheatActive(object o, EventArgs e) { }

        public override void Toggle() => base.Toggle();
    }
}
