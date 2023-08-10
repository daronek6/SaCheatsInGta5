using GTA;
using System;

namespace SaCheats
{
    internal class WheelsOnlyPlease : Cheat
    {
        public WheelsOnlyPlease()
          : base(CheatType.Active, "WheelsOnlyPlease", "Invisible Cars")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            foreach (Vehicle vehicle in World.GetAllVehicles())
            {
                if (vehicle.Model.IsCar)
                {
                    vehicle.IsVisible = false;
                }
            }

            if(!Game.Player.Character.IsInVehicle())
            {
                Game.Player.Character.IsVisible = true;
            }
        }

        public override void Toggle()
        {
            base.Toggle();

            if(!Toggled)
            {
                foreach (Vehicle vehicle in World.GetAllVehicles())
                {
                    if (vehicle.Model.IsCar)
                    {
                        vehicle.IsVisible = true;
                        Game.Player.Character.IsVisible = true;
                    }
                }
            }
        }
    }
}
