using System;

namespace SaCheats
{
    internal class Rocketman : Cheat
    {
        public Rocketman()
          : base(CheatType.NotSupported, "Rocketman", "Spawns Jetpack")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
