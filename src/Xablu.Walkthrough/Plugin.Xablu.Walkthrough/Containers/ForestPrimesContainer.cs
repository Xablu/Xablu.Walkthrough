using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class ForestPrimesContainer : IContainer
    {
        public ImageButtonControl NextButtonControl { get; set; }

        public ButtonControl SkipButtonControl { get; set; }

        public ButtonControl StartButtonControl { get; set; }

        public Color BackgroundColor { get; set; }
    }
}
