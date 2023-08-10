using System;

namespace SaCheats
{
    internal class EveryoneIsPoor : Cheat
    {
        public EveryoneIsPoor()
          : base(CheatType.NotSupported, "EveryoneIsPoor", "All Cheap Cars")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
