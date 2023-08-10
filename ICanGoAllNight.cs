using System;

namespace SaCheats
{
    internal class ICanGoAllNight : Cheat
    {
        public ICanGoAllNight()
          : base(CheatType.NotSupported, "ICanGoAllNight", "Maximum Stamina")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {

        }

        public override void Toggle() => base.Toggle();
    }
}
