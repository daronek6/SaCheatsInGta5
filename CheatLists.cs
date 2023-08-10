using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    public class CheatLists
    {
        private SaCheatsScript script;
        private int snippetLen = 0;

        private LinkedList<Cheat> instantCheatsList;
        private LinkedList<Cheat> activeCheatsList;
        private LinkedList<Cheat> notSupportedCheatsList;

        private LinkedList<Cheat> instantCheatsSnippet;
        private LinkedList<Cheat> activeCheatsSnippet;

        public CheatLists(SaCheatsScript scr)
        {
            script = scr;

            instantCheatsList = new LinkedList<Cheat>();
            activeCheatsList = new LinkedList<Cheat>();
            notSupportedCheatsList = new LinkedList<Cheat>();
        }

        public void InitSnippets(int len)
        {
            snippetLen = len;
            instantCheatsSnippet = new LinkedList<Cheat>();
            activeCheatsSnippet = new LinkedList<Cheat>();

            for (int i = 0; i < snippetLen; i++)
            {
                instantCheatsSnippet.AddLast(instantCheatsList.ElementAt(i));
                activeCheatsSnippet.AddLast(activeCheatsList.ElementAt(i));
            }
            //script.showMsg("Inst " + instantCheatsList.Count.ToString() + " Act " + activeCheatsList.Count.ToString(), 50000);
        }

        public void UpdateInstantSnippet(int startIndex)
        {
            instantCheatsSnippet.Clear();

            startIndex = startIndex % instantCheatsList.Count;

            for (int i = 0; i < snippetLen; i++)
            {
                instantCheatsSnippet.AddLast(instantCheatsList.ElementAt(startIndex));

                startIndex = (startIndex + 1) % instantCheatsList.Count;
            }
        }

        public void UpdateActiveSnippet(int startIndex)
        {
            activeCheatsSnippet.Clear();

            startIndex = startIndex % activeCheatsList.Count;

            for (int i = 0; i < snippetLen; i++)
            {
                activeCheatsSnippet.AddLast(activeCheatsList.ElementAt(startIndex));

                startIndex = (startIndex + 1) % activeCheatsList.Count;
            }
        }

        public int GetInstantCheatsListCount()
        {
            return instantCheatsList.Count;
        }

        public int GetActiveCheatListCount()
        {
            return activeCheatsList.Count;
        }

        public void ActivateInstantSnippetCheat(int index)
        {
            script.ActivateCheat(instantCheatsSnippet.ElementAt(index));
        }

        public void ActivateActiveSnippetCheat(int index)
        {
            script.ActivateCheat(activeCheatsSnippet.ElementAt(index));
        }

        public LinkedList<Cheat> GetInstantSnippet()
        {
            return instantCheatsSnippet;
        }

        public LinkedList<Cheat> GetActiveSnippet()
        {
            return activeCheatsSnippet;
        }

        public void AddInstantCheat(Cheat cheat)
        {
            instantCheatsList.AddFirst(cheat);
        }

        public void AddActiveCheat(Cheat cheat)
        {
            activeCheatsList.AddFirst(cheat);
        }

        public void AddNotSupportedCheat(Cheat cheat)
        {
            notSupportedCheatsList.AddFirst(cheat);
        }

        public void AddCheat(Cheat cheat)
        {
            if (cheat.GetCheatType() == CheatType.Instant) { AddInstantCheat(cheat);  }
            else if (cheat.GetCheatType() == CheatType.Active) { AddActiveCheat(cheat); }
            else if (cheat.GetCheatType() == CheatType.NotSupported) { AddNotSupportedCheat(cheat);  }
        }

        public Cheat GetInstantCheatByName(string name)
        {
            Cheat tmpCheat = null;
            try
            {
                tmpCheat = instantCheatsList.Where((x) => x.GetName() == name).ToArray().First();
            }
            catch (Exception ex)
            {
                return null;
            }
            return tmpCheat;
        }

        public Cheat GetTriggerableCheatByName(string name)
        {
            Cheat tmpCheat = null;
            try
            {
                tmpCheat = activeCheatsList.Where((x) => x.GetName() == name).ToArray().First();
            }
            catch (Exception ex)
            {
                return null;
            }
            return tmpCheat;
        }

        public Cheat GetNotSupportedCheatByName(string name)
        {
            Cheat tmpCheat = null;
            try
            {
                tmpCheat = notSupportedCheatsList.Where((x) => x.GetName() == name).ToArray().First();
            }
            catch(Exception ex)
            {
                return null;
            }
            return tmpCheat;
        }

        public Cheat GetCheatByName(string name)
        {
            Cheat tmpCheat = null;
            tmpCheat = GetInstantCheatByName(name);

            if(tmpCheat == null)
            {
                tmpCheat = GetTriggerableCheatByName(name);
            }
            if(tmpCheat == null)
            {
                tmpCheat = GetNotSupportedCheatByName(name);
            }

            return tmpCheat;
        }

        public Cheat GetInstantCheatByIndex(int index)
        {
            try
            {
                return instantCheatsList.ElementAt(index);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                return null;
            }
            
        }

        public Cheat GetActiveCheatByIndex(int index)
        {
            try
            {
                return activeCheatsList.ElementAt(index);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                return null;
            }
        }

        public Cheat GetNotSupportedCheatByIndex(int index)
        {
            try
            {
                return notSupportedCheatsList.ElementAt(index);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                return null;
            }
        }

        public Cheat GetActiveCheatByHash(UInt32 hash)
        {
            Cheat tmpCheat = null;
            foreach(Cheat cheat in activeCheatsList)
            {
                if(cheat.GetHash() == hash)
                {
                    return cheat;
                }
            }
            return tmpCheat;
        }

        public Cheat GetInstantCheatByHash(UInt32 hash)
        {
            Cheat tmpCheat = null;
            try
            {
                tmpCheat = instantCheatsList.Where((x) => x.GetHash() == hash).ToArray().First();
            }catch(Exception ex)
            {
                return null;
            }
            
            return tmpCheat;
        }

        public Cheat GetNotSupportedCheatByHash(UInt32 hash)
        {
            Cheat tmpCheat = null;
            try
            {
                tmpCheat = notSupportedCheatsList.Where((x) => x.GetHash() == hash).ToArray().First();
            }
            catch(Exception ex)
            {
                return null;
            }
            return tmpCheat;
        }

        public Cheat GetCheatByHash(UInt32 hash)
        {
            Cheat tmpCheat = null;
            tmpCheat = GetInstantCheatByHash(hash);
            if(tmpCheat == null)
            {
                tmpCheat = GetActiveCheatByHash(hash);
            }
            if(tmpCheat == null)
            {
                tmpCheat = GetNotSupportedCheatByHash(hash);
            }

            return tmpCheat;
        }

        public string GetHashes()
        {
            string tmp = "";
            foreach(Cheat cheat in instantCheatsList)
            {
                tmp += cheat.GetName() + " : " + cheat.GetHash().ToString("X") + ", ";
            }
            return tmp;
        }
    }
}
