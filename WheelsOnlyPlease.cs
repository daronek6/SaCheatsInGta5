using GTA;
using System;

namespace SaCheats
{
    internal class WheelsOnlyPlease : Cheat
    {
        public WheelsOnlyPlease()
          : base(CheatType.Active, "WheelsOnlyPlease", "Invisible Car (Only Wheels Visible)")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            foreach (Vehicle allVehicle in World.GetAllVehicles())
            {
                Model model = ((Entity)allVehicle).Model;
                int num;
                if (!model.IsBicycle)
                {
                    model = ((Entity)allVehicle).Model;
                    if (!model.IsCar)
                    {
                        model = ((Entity)allVehicle).Model;
                        num = model.IsBike ? 1 : 0;
                        if (num != 0)
                            ((Entity)allVehicle).IsVisible = false;
                    }
                }
            }
        }

        public override void Toggle()
        {
            base.Toggle();
            if (this.Toggled)
                return;
            foreach (Vehicle allVehicle in World.GetAllVehicles())
            {
                Model model = ((Entity)allVehicle).Model;
                int num;
                if (!model.IsBicycle)
                {
                    model = ((Entity)allVehicle).Model;
                    if (!model.IsCar)
                    {
                        model = ((Entity)allVehicle).Model;
                        num = model.IsBike ? 1 : 0;
                        if (num != 0)
                            ((Entity)allVehicle).IsVisible = true;
                    }
                }
            }
        }
    }
}
