using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    class CheatListUI
    {
        private List<UIElement> list;
        private DescriptionUI description;

        public CheatListUI(int len, LinkedList<Cheat> snippet)
        {
            list = new List<UIElement>();
            description = new DescriptionUI();

            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                    list.Add(new UIElement(true, false, i));
                else
                    list.Add(new UIElement(false, false, i));
            }

            UpdateList(0, 0, snippet);
        }

        public void Draw()
        {
            foreach(UIElement uiElement in list)
            {
                uiElement.Draw();
            }
            description.Draw();
        }

        public void UpdateSelection(int selectedIndex, int prevSelectedIndex)
        {

            UnSelectItem(prevSelectedIndex);
            SelectItem(selectedIndex);
        }

        public void UpdateList(int selectedIndex, int prevSelectedIndex, LinkedList<Cheat> snippet)
        {
            for (int i = 0; i < snippet.Count; i++)
            {
                UpdateItemText(i, snippet.ElementAt(i).GetName());
                ToggleItem(i, snippet.ElementAt(i).Toggled);
            }

            UpdateDescription(snippet.ElementAt(selectedIndex).GetDescription());
            UnSelectItem(prevSelectedIndex);
            SelectItem(selectedIndex);
        }

        public void SelectItem(int index)
        {
            list.ElementAt(index).Select();
        }
        public void UnSelectItem(int index)
        {
            list.ElementAt(index).UnSelect();
        }
        public void ToggleItem(int index, bool toggled)
        {
            list.ElementAt(index).Toggle(toggled);
        }
        public void UpdateItemText(int index, String text)
        {
            list.ElementAt(index).UpdateText(text);
        }
        public void UpdateDescription(String text)
        {
            description.UpdateText(text);
        }
    }
}
