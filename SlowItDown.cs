using GTA;
using System;

namespace SaCheats
{
    internal class SlowItDown : Cheat
    {
        private int lvl;

        public SlowItDown()
          : base(CheatType.Instant, "SlowItDown", "Slow Motion (First Time - Slow, Secound - Slower, Third - Normal Speed)")
        {
            this.lvl = 0;
        }

        public override void CheatActive(object o, EventArgs e)
        {
            if (this.lvl == 0)
            {
                Game.TimeScale = 0.7f;
                ++this.lvl;
            }
            else if (this.lvl == 1)
            {
                Game.TimeScale = 0.5f;
                ++this.lvl;
            }
            else
            {
                Game.TimeScale = 1f;
                this.lvl = 0;
            }
        }

        public override void Toggle() => base.Toggle();
    }
}
