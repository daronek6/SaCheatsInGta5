using System;
using GTA;

namespace SaCheats
{
    class LetsGoBaseJumping : Cheat
    {
        public LetsGoBaseJumping() : base(CheatType.Instant, "LetsGoBaseJumping", "Gives Parachute") { }

        public override void CheatActive(object o, EventArgs e)
        {
            Game.Player.Character.Weapons.Give(WeaponHash.Parachute, 1, true, true);
        }
    }
}
