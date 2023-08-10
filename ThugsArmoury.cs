using GTA;
using System;

namespace SaCheats
{
    internal class ThugsArmoury : Cheat
    {
        public ThugsArmoury()
          : base(CheatType.Instant, "ThugsArmoury", "Gives First Set Of Weapons")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            Game.Player.Character.Weapons.Give(WeaponHash.Bat, 1, false, true);
            Game.Player.Character.Weapons.Give(WeaponHash.KnuckleDuster, 1, false, true);
            Game.Player.Character.Weapons.Give(WeaponHash.Pistol, 0, false, true).Ammo += 100;
            Game.Player.Character.Weapons.Give(WeaponHash.PumpShotgun, 0, false, true).Ammo += 50;
            Game.Player.Character.Weapons.Give(WeaponHash.MicroSMG, 0, false, true).Ammo += 150;
            Game.Player.Character.Weapons.Give(WeaponHash.AssaultRifle, 0, false, true).Ammo += 120;
            Game.Player.Character.Weapons.Give(WeaponHash.Musket, 0, false, true).Ammo += 25;
            Game.Player.Character.Weapons.Give(WeaponHash.RPG, 0, false, true).Ammo += 200;
            Game.Player.Character.Weapons.Give(WeaponHash.Molotov, 0, false, true).Ammo += 10;
        }

        public override void Toggle() => base.Toggle();
    }
}
