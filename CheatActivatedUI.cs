using GTA.UI;
using System.Drawing;

namespace SaCheats
{
    class CheatActivatedUI
    {
        private const string TEXT_CHEATACTIVATED = "Cheat activated";
        private const string TEXT_CHEATDEACTIVATED = "Cheat deactivated";
        private const string TEXT_CHEATNOTSUPORTED = "Not supported";

        private const long CHEATMSGDURATION = 1500000000L;

        private ContainerElement uiContainer;
        private TextElement uiTextElement;

        private long endShowingCheatMsg = 0;

        public CheatActivatedUI()
        {
            this.uiContainer = new ContainerElement(new Point(90, 50), new Size((int)byte.MaxValue, 30), Color.FromArgb(180, 0, 0, 0));
            this.uiTextElement = new TextElement(" ", new Point(100, 52), 0.5f, Color.FromArgb(180, (int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue), (GTA.UI.Font)0, Alignment.Left);
        }

        public void UpdateUI(Cheat cheat)
        {
            if(cheat.GetCheatType() == CheatType.NotSupported)
            {
                uiTextElement.Caption = TEXT_CHEATNOTSUPORTED;
            }
            else if(cheat.GetCheatType() == CheatType.Instant)
            {
                uiTextElement.Caption = TEXT_CHEATACTIVATED;
            }
            else
            {
                if(cheat.Toggled)
                {
                    uiTextElement.Caption = TEXT_CHEATACTIVATED;
                }
                else
                {
                    uiTextElement.Caption = TEXT_CHEATDEACTIVATED;
                }
            }

            endShowingCheatMsg = Util.nanoTime() + CHEATMSGDURATION;
        }

        public void DrawUI()
        {
            if(Util.nanoTime() <= this.endShowingCheatMsg)
            {
                uiContainer.Draw();
                uiTextElement.Draw();
            }
        }
    }
}
