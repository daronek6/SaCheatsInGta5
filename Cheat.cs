using System;

namespace SaCheats
{
    public abstract class Cheat
    {
        public bool Toggled;
        public CheatType type;
        private CheatDescription cheatDescription;

        public Cheat(CheatType t)
        {
            this.type = t;
            this.Toggled = false;
            cheatDescription = new CheatDescription();
        }
        public Cheat(CheatType t, string name, string desc)
        {
            this.type = t;
            this.Toggled = false;
            cheatDescription = new CheatDescription(name, desc);
        }

        public abstract void CheatActive(object o, EventArgs e);

        public virtual void Toggle() => this.Toggled = !this.Toggled;

        public string GetName()
        {
            return cheatDescription.Name;
        }

        public string GetDescription()
        {
            return cheatDescription.Description;
        }

        public UInt32 GetHash()
        {
            return cheatDescription.Hash;
        }

        public CheatType GetCheatType()
        {
            return type;
        }
    }
}
