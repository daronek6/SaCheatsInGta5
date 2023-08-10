using System;

namespace SaCheats
{
    internal class DontTryAndStopMe : Cheat
    {
        public DontTryAndStopMe()
          : base(CheatType.NotSupported, "DontTryAndStopMe", "All Traffic Lights Are Green")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
