using System;

namespace SaCheats
{
    internal class NaturalTalent : Cheat
    {
        public NaturalTalent()
          : base(CheatType.NotSupported, "NaturalTalent", "Maximize All Vehicle Skill Stats")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
