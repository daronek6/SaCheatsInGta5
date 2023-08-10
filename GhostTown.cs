using System;

namespace SaCheats
{
    internal class GhostTown : Cheat
    {
        public GhostTown()
          : base(CheatType.NotSupported, "GhostTown", "Reduced Traffic")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
