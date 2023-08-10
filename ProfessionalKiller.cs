using System;

namespace SaCheats
{
    internal class ProfessionalKiller : Cheat
    {
        public ProfessionalKiller()
          : base(CheatType.NotSupported, "ProfessionalKiller", "Maximum Shooting Skill")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
