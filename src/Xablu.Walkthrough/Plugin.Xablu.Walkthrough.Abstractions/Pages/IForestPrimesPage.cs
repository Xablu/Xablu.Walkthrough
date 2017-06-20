using System;
using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Pages
{
    public interface IForestPrimesPage : IPage
    {
        Color BackgroundColor { get; set; }

        TextControl TitleControl { get; set; }

        ImageControl CenterImageControl { get; set; }

        TextControl DescriptionControl { get; set; }
    }
}
