using GTA;
using System;

namespace SaCheats
{
    internal class TakeAChillPill : Cheat
    {
        public TakeAChillPill()
          : base(CheatType.Active, "TakeAChillPill", "Ardrenaline Mode (Slow Motion)")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle()
        {
            base.Toggle();
            if (this.Toggled)
                Game.TimeScale = 0.4f;
            else
                Game.TimeScale = 1f;
        }
    }
}
