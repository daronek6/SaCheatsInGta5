using GTA;
using System;

namespace SaCheats
{
    internal class SpeedItUp : Cheat
    {
        public SpeedItUp()
          : base(CheatType.Active, "SpeedItUp", "Fast Motion")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle()
        {
            base.Toggle();
            if (this.Toggled)
                Game.TimeScale = 1.1f;
            else
                Game.TimeScale = 1f;
        }
    }
}
