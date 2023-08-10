using GTA;
using System;

namespace SaCheats
{
    internal class INeedSomeHelp : Cheat
    {
        public INeedSomeHelp()
          : base(CheatType.Instant, "INeedSomeHelp", "Restores Full Health, Gives Armor And $250k")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            Game.Player.Money += 250000;
            ((Entity)Game.Player.Character).Health = 200;
            Game.Player.Character.Armor = 200;
            if (!Game.Player.Character.IsInVehicle())
                return;
            Vehicle playerVehicle = Game.Player.Character.CurrentVehicle;
            if (playerVehicle != null)
            {
                playerVehicle.Repair();
            }
        }

        public override void Toggle() => base.Toggle();
    }
}
