using System;
using GTA.UI;
using System.Drawing;

namespace SaCheats
{
    class UIElement
    {
        static private Color boxSelectedFrameColor = Color.Red;
        static private Color boxNotSelectedFrameColor = Color.Black;
        static private Color boxColor = Color.FromArgb(200, 0, 0, 0);
        static private Color boxToggledColor = Color.FromArgb(200, Color.Blue);

        static private Color fontColor = Color.White;
        static private GTA.UI.Font font = GTA.UI.Font.ChaletLondon;
        static private float textPadding = 3;
        static private float textScale = 0.4f;
        private String text;

        static private float startX = 50;
        static private float startY = 50;
        static private float width = 250;
        static private float height = 30;
        static private SizeF frameSize = new SizeF(width, height);
        static private float boxPadding = 2;
        private SizeF boxSize = new SizeF(width - 2 * boxPadding, height - 2 * boxPadding);
        private float gap = height + 10;

        private int index;

        private ContainerElement frameElement;
        private ContainerElement boxElement;
        private TextElement textElement;

        public UIElement(bool sel, bool tog, int i)
        {
            text = "TEXT TEST !1234?";
            index = i;

            if(sel)
                frameElement = new ContainerElement(new PointF(startX, startY + i * gap), frameSize, boxSelectedFrameColor);
            else
                frameElement = new ContainerElement(new PointF(startX, startY + i * gap), frameSize, boxNotSelectedFrameColor);

            if (tog)
                boxElement = new ContainerElement(new PointF(startX + boxPadding, startY + boxPadding + i * gap), boxSize, boxToggledColor);
            else 
                boxElement = new ContainerElement(new PointF(startX + boxPadding, startY + boxPadding + i * gap), boxSize, boxColor);

            textElement = new TextElement(text, new PointF(startX + boxPadding + textPadding, startY + boxPadding + textPadding + i * gap), textScale, fontColor, font, Alignment.Left);
        }

        public void Draw()
        {
            frameElement.Draw();
            boxElement.Draw();
            textElement.Draw();
        }

        public void Select()
        {
            frameElement.Color = boxSelectedFrameColor;
        }

        public void UnSelect()
        {
            frameElement.Color = boxNotSelectedFrameColor;
        }

        public void Toggle(bool toggled)
        {
            if (!toggled)
                boxElement.Color = boxColor;
            else
                boxElement.Color = boxToggledColor;
        }

        public void UpdateText(String txt)
        {
            text = txt;
            textElement.Caption = text;
        }
    }
}
