using GTA;
using System;

namespace SaCheats
{
    internal class ManFromAtlantis : Cheat
    {
        public ManFromAtlantis()
          : base(CheatType.Active, "ManFromAtlantis", "Infinite Oxygen")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle()
        {
            base.Toggle();
            Game.Player.Character.DrownsInWater = !this.Toggled;
        }
    }
}
