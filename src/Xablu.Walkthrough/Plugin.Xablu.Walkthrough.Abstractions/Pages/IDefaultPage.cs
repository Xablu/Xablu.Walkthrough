using System;
using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Pages
{
    public interface IDefaultPage : IPage
    {
        Color BackgroundColor { get; set; }

        TextControl TitleControl { get; set; }

        ImageControl ImageControl { get; set; }

        TextControl DescriptionControl { get; set; }
    }
}