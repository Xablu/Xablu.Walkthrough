using System;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using static Android.Support.V4.View.ViewPager;
using System.Drawing;
using Splat;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class PantheonContainer : BaseContainer
    {
        public ButtonControl GetStartedButtonControl { get; set; }

        public Color BackgroundColor { get; set; }

        public PantheonContainer()
        {
        }
    }
}
