using System;
using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Containers
{
    public interface IPantheonContainer : IContainer
    {
        ButtonControl GetStartedButtonControl { get; set; }

        Color BackgroundColor { get; set; }

        PageControl CirclePageControl { get; set; }
    }
}
