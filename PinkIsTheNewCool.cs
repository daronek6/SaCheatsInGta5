using GTA;
using System;

namespace SaCheats
{
    internal class PinkIsTheNewCool : Cheat
    {
        public PinkIsTheNewCool()
          : base(CheatType.Active, "PinkIsTheNewCool", "Pink Cars")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            foreach (Vehicle vehicle in World.GetAllVehicles())
            {
                vehicle.Mods.PrimaryColor = VehicleColor.HotPink;
                vehicle.Mods.SecondaryColor = VehicleColor.HotPink;
            }
        }

        public override void Toggle() => base.Toggle();
    }
}
