using GTA;
using System;

namespace SaCheats
{
    internal class StopPickingOnMe : Cheat
    {
        private long frame;
        private long prevFrame;

        public StopPickingOnMe()
          : base(CheatType.Active, "StopPickingOnMe", "People Want To Kill You")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
            this.frame = Util.nanoTime();
            if (frame - prevFrame < 3000000000L)
                return;
            foreach (Ped nearbyPed in World.GetNearbyPeds(Game.Player.Character.Position, 150f))
            {
                if (!nearbyPed.IsPlayer)
                {

                    nearbyPed.RelationshipGroup.SetRelationshipBetweenGroups(Game.Player.Character.RelationshipGroup, Relationship.Hate, true);
                }
            }
            this.prevFrame = this.frame;
        }

        public override void Toggle()
        {
            base.Toggle();
            this.prevFrame = Util.nanoTime() + 3000000000L;
        }
    }
}
