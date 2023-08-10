using GTA;
using System;

namespace SaCheats
{
    internal class NoOneCanHurtMe : Cheat
    {
        private long timeNow;
        private long timePrev;

        public NoOneCanHurtMe()
          : base(CheatType.Active, "NoOneCanHurtMe", "Invincibility")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            timeNow = Util.nanoTime();
            if (timeNow - timePrev >= 3000000000L)
            {
                Game.Player.Character.IsInvincible = true;
                timePrev = timeNow;
            }

        }

        public override void Toggle()
        {
            base.Toggle();
            timeNow = timePrev = Util.nanoTime();
            Game.Player.IsInvincible = this.Toggled;
        }
    }
}
