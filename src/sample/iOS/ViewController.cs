using System;
using System.Drawing;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Pages;
using Plugin.Xablu.Walkthrough.Themes;
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

            var x = new MyClass();
            var xy = new ForestPrimesPage();


            Button.TouchUpInside += (sender, e) =>
            {

                x.SetTheme();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
