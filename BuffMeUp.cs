using System;

namespace SaCheats
{
    internal class BuffMeUp : Cheat
    {
        public BuffMeUp()
          : base(CheatType.NotSupported, "BuffMeUp", "Max Muscles")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
