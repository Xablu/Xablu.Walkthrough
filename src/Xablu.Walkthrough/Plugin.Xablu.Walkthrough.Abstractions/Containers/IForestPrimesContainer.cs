using System;
using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Containers
{
    public interface IForestPrimesContainer : IContainer
    {
        ImageButtonControl NextButtonControl { get; set; }

        ButtonControl SkipButtonControl { get; set; }

        ButtonControl StartButtonControl { get; set; }

        Color BackgroundColor { get; set; }

        PageControl CirclePageControl { get; set; }
    }
}
