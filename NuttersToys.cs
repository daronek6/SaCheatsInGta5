using GTA;
using System;

namespace SaCheats
{
    internal class NuttersToys : Cheat
    {
        public NuttersToys()
          : base(CheatType.Instant, "NuttersToys", "Gives Third Set Of Weapons")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            Game.Player.Character.Weapons.Give(WeaponHash.Knife, 0, false, true);
            Game.Player.Character.Weapons.Give(WeaponHash.FireExtinguisher, 0, false, true).Ammo += 1000;
            Game.Player.Character.Weapons.Give(WeaponHash.HeavyPistol, 0, false, true).Ammo += 30;
            Game.Player.Character.Weapons.Give(WeaponHash.SawnOffShotgun, 0, false, true).Ammo += 100;
            Game.Player.Character.Weapons.Give(WeaponHash.APPistol, 0, false, true).Ammo += 150;
            Game.Player.Character.Weapons.Give(WeaponHash.CarbineRifle, 0, false, true).Ammo += 200;
            Game.Player.Character.Weapons.Give(WeaponHash.Grenade, 0, false, true).Ammo += 5;
        }

        public override void Toggle() => base.Toggle();
    }
}
