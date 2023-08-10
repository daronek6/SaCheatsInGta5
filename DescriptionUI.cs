using System;
using GTA.UI;
using System.Drawing;

namespace SaCheats
{
    class DescriptionUI
    {
        static private Color boxColor = Color.FromArgb(140, 0, 0, 0);
        static private float startX = 320;
        static private float startY = 50;
        static private float width = 250;
        static private float height = 120;
        private PointF position = new PointF(startX, startY);
        private SizeF boxSize = new SizeF(width, height);

        static private Color fontColor = Color.White;
        static private GTA.UI.Font font = GTA.UI.Font.ChaletLondon;
        static private float textPadding = 5;
        static private float textScale = 0.4f;
        private PointF textBoxPosition = new PointF(startX + textPadding, startY + textPadding);
        private String text;

        private ContainerElement boxElement;
        private TextElement textElement;

        public DescriptionUI()
        {
            text = "No description.";
            boxElement = new ContainerElement(position, boxSize, boxColor);
            textElement = new TextElement(text, textBoxPosition, textScale, fontColor, font, Alignment.Left, true, true, width - 2 * textPadding);
        }
        public void UpdateText(String txt)
        {
            text = txt;
            textElement.Caption = text;
        }
        public void Draw()
        {
            boxElement.Draw();
            textElement.Draw();
        }
    }
}
