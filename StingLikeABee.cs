using System;
using GTA;

namespace SaCheats
{
    class StingLikeABee : Cheat
    {
        private Ped recentTarget;

        public StingLikeABee() : base(CheatType.Active, "StingLikeABee", "Mega punch") { recentTarget = null; }

        public override void CheatActive(object o, EventArgs e)
        {
            Ped target = Game.Player.Character.MeleeTarget;

            if (recentTarget != target && target != null && target.HasBeenDamagedBy(Game.Player.Character))
            {
                recentTarget = target;
                target.Kill();
                target.ApplyForce(Game.Player.Character.ForwardVector * 100f);
             
            }
        }
    }
}
