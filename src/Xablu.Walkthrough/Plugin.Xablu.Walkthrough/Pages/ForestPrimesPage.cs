using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class ForestPrimesPage : IPage
    {
        public Color BackgroundColor = Color.PaleGreen;

        public TextControl TitleControl;

        public ImageControl CenterImageControl;

        public TextControl DescriptionControl;
    }
}
