﻿using System;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using UIKit;

namespace WalkthroughSample.iOS
{
    public partial class ViewController : UIViewController, IContainer
    {
        public ViewController() { }
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            CrossWalkthrough.Current.Init(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Button.TouchUpInside += (sender, e) => ForestPrimesSamples.ShowForestContainerForestPage();
            PantheonForest.TouchUpInside += (sender, e) => PantheonSamples.ShowPantheonContainerForestPage();
            VestaButton.TouchUpInside += (sender, e) => VestaSamples.ShowVestaContainerVestaPage();
            VestaAltButton.TouchUpInside += (sender, e) => VestaAltSamples.ShowVestaAltContainerVestaPage();
            ForestOvu.TouchUpInside += (sender, e) => ForestPrimesSamples.ShowForestContainerOvuPage();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
