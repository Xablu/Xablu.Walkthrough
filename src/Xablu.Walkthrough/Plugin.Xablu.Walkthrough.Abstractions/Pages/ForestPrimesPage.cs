using System;
using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Themes;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class ForestPrimesPage : IPage
    {
        public Color BackgroundColor = Color.PaleGreen;

        public TextControl TitleControl;

        public ImageControl CenterImage;

        public TextControl DescriptionControl;

        public ButtonControl FinishedButton;
    }
}
