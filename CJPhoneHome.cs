using GTA;
using GTA.Math;
using System;
using System.Windows.Forms;

namespace SaCheats
{
    internal class CJPhoneHome : Cheat
    {
        private Script script;
        private bool isTimerOn;
        private long start;
        private long end;
        private long howLong;

        public CJPhoneHome(Script thisMod)
          : base(CheatType.Active, "CJPhoneHome", "Big Bunny Hop On Bikes")
        {
            this.howLong = 0L;
            this.start = 0L;
            this.isTimerOn = false;
            this.script = thisMod;
        }

        public override void CheatActive(object o, EventArgs e)
        {
        }

        public void OnKeyDown(object o, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space || this.isTimerOn)
                return;
            this.SetStartingTime();
        }

        public void OnKeyUp(object o, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
                return;
            if (Game.Player.Character.CurrentVehicle != null)
            {
                Model model = Game.Player.Character.CurrentVehicle.Model;
                if (model != null && model.IsBicycle && this.isTimerOn)
                {
                    this.isTimerOn = false;
                    this.end = Util.nanoTime();
                    this.howLong = this.end - this.start;
                    this.jump();
                }
            }

        }

        public void SetStartingTime()
        {
            this.start = Util.nanoTime();
            this.isTimerOn = true;
        }

        public void jump()
        {
            if ((double)((Entity)Game.Player.Character).HeightAboveGround >= 2.0)
                return;
            Vector3 zero = Vector3.Zero;
            if (this.howLong > 10000000L && this.howLong <= 50000000L)
                zero.Z = 18f;
            if (this.howLong > 50000000L && this.howLong <= 100000000L)
                zero.Z = 28f;
            else if (this.howLong > 100000000L && this.howLong <= 200000000L)
                zero.Z = 45f;
            else if (this.howLong > 200000000L)
                zero.Z = 69f;
            ((Entity)Game.Player.Character.CurrentVehicle).ApplyForce(zero);
            this.start = 0L;
            this.end = 0L;
        }

        public override void Toggle()
        {
            base.Toggle();
            if (this.Toggled)
            {
                this.script.KeyDown += new KeyEventHandler(this.OnKeyDown);
                this.script.KeyUp += new KeyEventHandler(this.OnKeyUp);
            }
            else
            {
                this.script.KeyDown -= new KeyEventHandler(this.OnKeyDown);
                this.script.KeyUp -= new KeyEventHandler(this.OnKeyUp);
            }
        }
    }
}
