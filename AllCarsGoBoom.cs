using GTA;
using System;

namespace SaCheats
{
    internal class AllCarsGoBoom : Cheat
    {
        public AllCarsGoBoom()
          : base(CheatType.Instant, "AllCarsGoBoom", "Blow Up Nearby Cars")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            foreach (Vehicle nearbyVehicle in World.GetNearbyVehicles(Game.Player.Character.Position, 100f))
            {
                if (nearbyVehicle.IsAlive)
                    nearbyVehicle.Explode();
            }
        }

        public override void Toggle() => base.Toggle();
    }
}
