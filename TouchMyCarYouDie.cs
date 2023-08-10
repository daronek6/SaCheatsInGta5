using GTA;
using System;

namespace SaCheats
{
    internal class TouchMyCarYouDie : Cheat
    {

        Vehicle currnetVehicle;
        Vehicle[] nearbyVehicles;

        public TouchMyCarYouDie()
          : base(CheatType.Active, "TouchMyCarYouDie", "Vehicles Explode On Impact With Player's Vehicle")
        {
            currnetVehicle = null;
            nearbyVehicles = null;
        }

        public override void CheatActive(object o, EventArgs e)
        {
            if(currnetVehicle != null && Game.Player.Character.CurrentVehicle != currnetVehicle)
            {
                currnetVehicle.IsExplosionProof = false;
            }

            currnetVehicle = Game.Player.Character.CurrentVehicle;

            if(currnetVehicle != null)
            {
                currnetVehicle.IsExplosionProof = true;
                nearbyVehicles = World.GetNearbyVehicles(currnetVehicle.Position, 10f);
                foreach(Vehicle veh in nearbyVehicles)
                {
                    if(veh.IsTouching(currnetVehicle) && veh != currnetVehicle)
                    {
                        if(veh.IsAlive)
                        {
                            veh.Explode();
                        }
                    }
                }
                
            }
        }

        public override void Toggle()
        {
            base.Toggle();

        }
    }
}
