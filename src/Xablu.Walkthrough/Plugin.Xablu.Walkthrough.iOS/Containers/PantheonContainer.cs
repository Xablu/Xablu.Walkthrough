using System;
using System.Drawing;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using Splat;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public partial class PantheonContainer : BWWalkthroughViewController, IContainer
    {
        public ButtonControl GetStartedButtonControl { get; set; }

        public Color BackgroundColor { get; set; }

        public PantheonContainer() : base("PantheonContainer", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            base.PageControl = PageControl;

            View.BackgroundColor = BackgroundColor.ToNative();

            StartButton.SetControl(GetStartedButtonControl);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

