using GTA;
using System;

namespace SaCheats
{
    internal class ProfessionalsKit : Cheat
    {
        public ProfessionalsKit()
          : base(CheatType.Instant, "ProfessionalsKit", "Gives Secound Set Of Weapons")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            Game.Player.Character.Weapons.Give(WeaponHash.Machete, 1, false, true);
            Game.Player.Character.Weapons.Give(WeaponHash.MarksmanPistol, 0, false, true).Ammo += 40;
            Game.Player.Character.Weapons.Give(WeaponHash.AssaultShotgun, 0, false, true).Ammo += 40;
            Game.Player.Character.Weapons.Give(WeaponHash.SMG, 0, false, true).Ammo += 150;
            Game.Player.Character.Weapons.Give(WeaponHash.BullpupRifle, 0, false, true).Ammo += 21;
            Game.Player.Character.Weapons.Give(WeaponHash.StickyBomb, 0, false, true).Ammo += 10;
            Game.Player.Character.Weapons.Give(WeaponHash.HomingLauncher, 0, false, true).Ammo += 200;
        }

        public override void Toggle() => base.Toggle();
    }
}
