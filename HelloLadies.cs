using System;

namespace SaCheats
{
    internal class HelloLadies : Cheat
    {
        public HelloLadies()
          : base(CheatType.NotSupported, "HelloLadies", "Maximum Sex Appeal")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
