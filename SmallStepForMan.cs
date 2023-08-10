using System;
using GTA;


namespace SaCheats
{
    class SmallStepForMan : Cheat
    {
        private float moonGravity = 1.6f;
        private float earthGravity = 9.8f;
        public SmallStepForMan() : base(CheatType.Active, "SmallStepForMan", "Moon gravity") { }

        public override void CheatActive(object o, EventArgs e)
        {
            
        }

        public override void Toggle()
        {
            base.Toggle();

            if(Toggled)
            {
                World.GravityLevel = moonGravity;
            }
            else
            {
                World.GravityLevel = earthGravity;
            }
        }
    }
}
