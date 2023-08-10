using GTA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    internal class OnlyHomiesAllowed : Cheat
    {
        private List<PedHash> pedsList = new List<PedHash>();
        private int index;
        private bool isSpecificModel;

        public OnlyHomiesAllowed()
          : base(CheatType.NotSupported, "OnlyHomiesAllowed", "Spawn Ballas And GSF")
        {
            this.pedsList.Add(PedHash.BallaEast01GMY);
            this.pedsList.Add(PedHash.BallaOrig01GMY);
            this.pedsList.Add(PedHash.Ballas01GFY);
            this.pedsList.Add(PedHash.BallasLeader);
            this.pedsList.Add(PedHash.LamarDavis);
        }

        public override void CheatActive(object o, EventArgs e)
        {
            foreach (Ped allPed in World.GetAllPeds())
            {
                this.index = 0;
                this.isSpecificModel = false;
                if (!allPed.IsPlayer && allPed.IsHuman)
                {
                    for (; !this.isSpecificModel && this.index < this.pedsList.Count; ++this.index)
                    {
                        if (((object)allPed).GetHashCode() == Convert.ToInt32(((IEnumerable<PedHash>)this.pedsList).ElementAt<PedHash>(this.index).ToString()))
                            this.isSpecificModel = true;
                    }
                    if (!this.isSpecificModel)
                        ;
                }
            }
        }

        public override void Toggle() => base.Toggle();
    }
}
