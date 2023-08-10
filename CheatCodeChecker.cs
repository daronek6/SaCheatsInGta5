using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SaCheats
{
    internal class CheatCodeChecker
    {
        private StringBuilder code;
        private SaCheatsScript script;
        private const int SIZE = 29;

        public CheatCodeChecker(SaCheatsScript script)
        {
            this.script = script;
            this.code = new StringBuilder(29);
        }
        public void AddInput(string input)
        {
            if (this.code.Length == SIZE)
                this.code.Remove(SIZE-1, 1);
            code.Insert(0, input.ToUpper());
            
        }

        public bool CheckForCheatCode(string pattern) => Regex.IsMatch(this.code.ToString(), pattern);

        public Cheat CheckForCheatCode()
        {
            Cheat activatedCheat = null;
            string tmpCode = "";
            UInt32 tmpHash = 0xFFFFFFFF;

            if (code.Length >= 6)
            {
                for(int i=6;i<code.Length;i++)
                {
                    tmpCode = code.ToString().Substring(0, i);
                    tmpHash = HashingAlgorithm.GetHash(tmpCode);
                    activatedCheat = script.cheatLists.GetCheatByHash(tmpHash);
                    if(activatedCheat != null)
                    {
                        ClearCode();
                        return activatedCheat;
                    }
                }
            }
            return activatedCheat;
        }

        public string GetCode() => this.code.ToString();

        private void ClearCode()
        {
            code.Clear();
        }
    }
}
