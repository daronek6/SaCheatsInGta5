using GTA;
using System;

namespace SaCheats
{
    internal class SoLongAsItsBlack : Cheat
    {
        public SoLongAsItsBlack()
          : base(CheatType.Active, "SoLongAsItsBlack", "Black Cars")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            foreach (Vehicle vehicle in World.GetAllVehicles())
            {
                vehicle.Mods.PrimaryColor = VehicleColor.MetallicBlack;
                vehicle.Mods.SecondaryColor = VehicleColor.MetallicBlack;
            }
        }

        public override void Toggle() => base.Toggle();
    }
}
