using System;

namespace SaCheats
{
    class CheatMenuUI
    {
        private const int LISTLENGTH = 4;
        private const int MAINMENUOPTIONS = 2;
        private static readonly String[] OPTIONS_TEXT = { "Instant Cheats", "Active Cheats" };

        private CheatLists cheats;
        private MainMenuUI mainMenuUI;
        private CheatListUI instantCheatsUI;
        private CheatListUI activeCheatsUI;

        private int mainMenuSelectedIndex = 0;

        private int instantCheatsSelectedIndex = 0;
        private int instantCheatsTopIndex = 0;

        private int activeCheatsSelectedIndex = 0;
        private int activeCheatsTopIndex = 0;

        private CheatMenuUIState state;
        public bool Enabled { get; set; }
        public CheatMenuUI(CheatLists cheatLists)
        {
            state = CheatMenuUIState.MainMenu;
            cheats = cheatLists;
            cheats.InitSnippets(LISTLENGTH);
            mainMenuUI = new MainMenuUI(MAINMENUOPTIONS, OPTIONS_TEXT);
            instantCheatsUI = new CheatListUI(LISTLENGTH, cheats.GetInstantSnippet());
            activeCheatsUI = new CheatListUI(LISTLENGTH, cheats.GetActiveSnippet());

            Enabled = false;
        }

        public void Draw()
        {
            if (Enabled)
            {
                switch (state)
                {
                    case CheatMenuUIState.MainMenu:
                        mainMenuUI.Draw();
                        break;
                    case CheatMenuUIState.InstantCheats:
                        instantCheatsUI.Draw();
                        break;
                    case CheatMenuUIState.ActiveCheats:
                        activeCheatsUI.Draw();
                        break;
                }
            }
        }

        public void MoveUp()
        {
            int prevSelectedIndex;
            if (Enabled)
            {
                switch (state)
                {
                    case CheatMenuUIState.MainMenu:
                        prevSelectedIndex = mainMenuSelectedIndex;
                        mainMenuSelectedIndex = Util.mod(mainMenuSelectedIndex - 1, MAINMENUOPTIONS);
                        mainMenuUI.UpdateSelection(mainMenuSelectedIndex, prevSelectedIndex);
                        break;
                    case CheatMenuUIState.InstantCheats:
                        if(instantCheatsSelectedIndex == 0)
                        {
                            instantCheatsTopIndex = Util.mod(instantCheatsTopIndex - 1, cheats.GetInstantCheatsListCount());
                            if(instantCheatsTopIndex == cheats.GetInstantCheatsListCount() - 1)
                            {
                                instantCheatsTopIndex = instantCheatsTopIndex - (LISTLENGTH - 1);
                                cheats.UpdateInstantSnippet(instantCheatsTopIndex);
                                instantCheatsUI.UpdateList(LISTLENGTH - 1, 0, cheats.GetInstantSnippet());
                                instantCheatsSelectedIndex = LISTLENGTH - 1;
                            }
                            else
                            {
                                cheats.UpdateInstantSnippet(instantCheatsTopIndex);
                                instantCheatsUI.UpdateList(0, 0, cheats.GetInstantSnippet());
                            }      
                        }
                        else
                        {
                            prevSelectedIndex = instantCheatsSelectedIndex;
                            instantCheatsSelectedIndex--;
                            instantCheatsUI.UpdateList(instantCheatsSelectedIndex, prevSelectedIndex, cheats.GetInstantSnippet());
                        }
                        break;
                    case CheatMenuUIState.ActiveCheats:
                        if (activeCheatsSelectedIndex == 0)
                        {
                            activeCheatsTopIndex = Util.mod(activeCheatsTopIndex - 1, cheats.GetActiveCheatListCount());
                            if(activeCheatsTopIndex == cheats.GetActiveCheatListCount() - 1)
                            {
                                activeCheatsTopIndex = activeCheatsTopIndex - (LISTLENGTH - 1);
                                cheats.UpdateActiveSnippet(activeCheatsTopIndex);
                                activeCheatsUI.UpdateList(LISTLENGTH - 1, 0, cheats.GetActiveSnippet());
                                activeCheatsSelectedIndex = LISTLENGTH - 1;
                            }    
                            else
                            {
                                cheats.UpdateActiveSnippet(activeCheatsTopIndex);
                                activeCheatsUI.UpdateList(0, 0, cheats.GetActiveSnippet());
                            }
                        }
                        else
                        {
                            prevSelectedIndex = activeCheatsSelectedIndex;
                            activeCheatsSelectedIndex--;
                            activeCheatsUI.UpdateList(activeCheatsSelectedIndex, prevSelectedIndex, cheats.GetActiveSnippet());
                        }
                        break;
                }
            }
        }

        public void MoveDown()
        {
            int prevSelectedIndex;
            if (Enabled)
            {
                switch (state)
                {
                    case CheatMenuUIState.MainMenu:
                        prevSelectedIndex = mainMenuSelectedIndex;
                        mainMenuSelectedIndex = Util.mod(mainMenuSelectedIndex + 1, MAINMENUOPTIONS);
                        mainMenuUI.UpdateSelection(mainMenuSelectedIndex, prevSelectedIndex);
                        break;
                    case CheatMenuUIState.InstantCheats:
                        if (instantCheatsSelectedIndex == (LISTLENGTH - 1))
                        {
                            if (instantCheatsTopIndex == cheats.GetInstantCheatsListCount() - LISTLENGTH)
                            {
                                instantCheatsTopIndex = 0;
                                instantCheatsSelectedIndex = 0;
                            }
                            else
                            {
                                instantCheatsTopIndex++;
                            }

                            cheats.UpdateInstantSnippet(instantCheatsTopIndex);
                            instantCheatsUI.UpdateList(instantCheatsSelectedIndex, LISTLENGTH - 1, cheats.GetInstantSnippet());
                        }
                        else
                        {
                            prevSelectedIndex = instantCheatsSelectedIndex;
                            instantCheatsSelectedIndex++;
                            instantCheatsUI.UpdateList(instantCheatsSelectedIndex, prevSelectedIndex, cheats.GetInstantSnippet());
                        }
                        break;
                    case CheatMenuUIState.ActiveCheats:
                        if (activeCheatsSelectedIndex == (LISTLENGTH - 1))
                        {
                            if(activeCheatsTopIndex == cheats.GetActiveCheatListCount() - LISTLENGTH)
                            {
                                activeCheatsTopIndex = 0;
                                activeCheatsSelectedIndex = 0;
                            }
                            else
                            {
                                activeCheatsTopIndex++;
                            }

                            cheats.UpdateActiveSnippet(activeCheatsTopIndex);
                            activeCheatsUI.UpdateList(activeCheatsSelectedIndex, LISTLENGTH - 1, cheats.GetActiveSnippet());
                        }
                        else
                        {
                            prevSelectedIndex = activeCheatsSelectedIndex;
                            activeCheatsSelectedIndex++;
                            activeCheatsUI.UpdateList(activeCheatsSelectedIndex, prevSelectedIndex, cheats.GetActiveSnippet());
                        }
                        break;
                }
            }
        }

        public void Click()
        {
            if (Enabled)
            {
                switch (state)
                {
                    case CheatMenuUIState.MainMenu:
                        if(mainMenuSelectedIndex == 0)
                        {
                            state = CheatMenuUIState.InstantCheats;
                        }
                        else if(mainMenuSelectedIndex == 1)
                        {
                            state = CheatMenuUIState.ActiveCheats;
                        }
                        break;
                    case CheatMenuUIState.InstantCheats:
                        cheats.ActivateInstantSnippetCheat(instantCheatsSelectedIndex);
                        break;
                    case CheatMenuUIState.ActiveCheats:
                        cheats.ActivateActiveSnippetCheat(activeCheatsSelectedIndex);
                        activeCheatsUI.UpdateList(activeCheatsSelectedIndex, activeCheatsSelectedIndex, cheats.GetActiveSnippet());
                        break;
                }
            }
        }

        public void Back()
        {
            if (Enabled)
            {
                switch (state)
                {
                    case CheatMenuUIState.MainMenu:
                        Enabled = false;
                        break;
                    case CheatMenuUIState.InstantCheats:
                    case CheatMenuUIState.ActiveCheats:
                        state = CheatMenuUIState.MainMenu;
                        break;
                }
            }
        }
    }
}
