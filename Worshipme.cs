using System;

namespace SaCheats
{
    internal class Worshipme : Cheat
    {
        public Worshipme()
          : base(CheatType.NotSupported, "Worshipme", "Maximum Respect")
        {
        }

        public override void CheatActive(object o, EventArgs e) { }

        public override void Toggle() => base.Toggle();
    }
}
