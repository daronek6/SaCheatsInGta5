using GTA;
using System;

namespace SaCheats
{
    internal class IDoAsIPlease : Cheat
    {
        public IDoAsIPlease()
          : base(CheatType.Active, "IDoAsIPlease", "Disable Wanted Level")
        {
        }

        public override void CheatActive(object o, EventArgs e) => Game.Player.WantedLevel = 0;

        public override void Toggle()
        {
            base.Toggle();
            Game.Player.IgnoredByPolice = this.Toggled;
        }
    }
}
