using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class ForestPrimesPage : IPage
    {
        public Color BackgroundColor = Color.PaleGreen;

        public TextControl TitleControl;

        public ImageControl CenterImage;

        public TextControl DescriptionControl;
    }
}
