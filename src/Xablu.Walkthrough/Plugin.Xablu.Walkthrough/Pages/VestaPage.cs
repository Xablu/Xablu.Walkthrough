using System;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class VestaPage : DefaultPage, IVestaPage
    {
        public ImageControl BackgroundImage { get; set; }
        public bool FadeBackgroundToBlack { get; set; }
    }
}