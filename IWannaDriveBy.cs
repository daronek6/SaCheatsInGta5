using System;

namespace SaCheats
{
    internal class IWannaDriveBy : Cheat
    {
        public IWannaDriveBy()
          : base(CheatType.NotSupported, "IWannaDriveBy", "Free Aim While Driving")
        {
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public override void Toggle() => base.Toggle();
    }
}
