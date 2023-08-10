using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    class MainMenuUI
    {
        private List<UIElement> options;
        public MainMenuUI(int len, String[] opts)
        {
            options = new List<UIElement>();
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                    options.Add(new UIElement(true, false, i));
                else
                    options.Add(new UIElement(false, false, i));
            }

            for (int i = 0; i < opts.Length; i++)
            {
                SetItemText(i, opts[i]);
            }
        }

        public void Draw()
        {
            foreach(UIElement option in options)
            {
                option.Draw();
            }
        }

        public void UpdateSelection(int selectedIndex, int prevSelectedIndex)
        {
            UnSelectItem(prevSelectedIndex);
            SelectItem(selectedIndex);
        }
        public void SetItemText(int index, String text)
        {
            options.ElementAt(index).UpdateText(text);
        }
        public void SelectItem(int index)
        {
            options.ElementAt(index).Select();
        }
        public void UnSelectItem(int index)
        {
            options.ElementAt(index).UnSelect();
        }
    }
}
