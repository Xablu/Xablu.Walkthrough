using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using System.Drawing;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class PantheonContainer : IContainer
    {
        public ButtonControl GetStartedButtonControl { get; set; }

        public Color BackgroundColor { get; set; }
    }
}
