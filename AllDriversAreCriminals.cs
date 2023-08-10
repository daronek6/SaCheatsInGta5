using GTA;
using System;

namespace SaCheats
{
    internal class AllDriversAreCriminals : Cheat
    {
        private long frame;
        private long nextFrame;
        private bool start;

        public AllDriversAreCriminals()
          : base(CheatType.Active, "AllDriversAreCriminals", "Aggressive Drivers")
        {
            this.start = true;
        }

        public override void CheatActive(object o, EventArgs e)
        {
            if (this.start)
            {
                this.frame = this.nextFrame = Util.nanoTime();
                this.start = false;
            }
            if (this.nextFrame - this.frame > 40000000L)
            {
                foreach (Vehicle nearbyVehicle in World.GetNearbyVehicles(Game.Player.Character.Position, 120f))
                {
                    if (nearbyVehicle.Driver != null)
                        nearbyVehicle.Driver.DrivingStyle = DrivingStyle.Rushed;
                }

                this.frame = this.nextFrame;
            }
            this.nextFrame = Util.nanoTime();
        }

        public override void Toggle()
        {
            base.Toggle();

            if (!this.Toggled)
                return;
            else
                this.start = true;
        }
    }
}
