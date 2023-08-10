using System;

namespace SaCheats
{
    internal class StateOfEmergency : Cheat
    {
        public StateOfEmergency()
          : base(CheatType.NotSupported, "StateOfEmergency", "Riot Mode")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
