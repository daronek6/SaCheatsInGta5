using System;

namespace SaCheats
{
    public class CheatDescription
    {
        private string name;
        private string description;
        private UInt32 hash;

        public string Name { get => name; }
        public string Description { get => description; }
        public UInt32 Hash { get => hash; }

        public CheatDescription()
        {
            name = "NoName";
            description = "NoDescription";
            hash = 0x00000000;
        }
        public CheatDescription(string n, string d)
        {
            name = n;
            description = d;
            char[] tmp = n.ToUpper().ToCharArray();
            Array.Reverse(tmp);

            hash = HashingAlgorithm.GetHash(new string(tmp));
        }

    }
}