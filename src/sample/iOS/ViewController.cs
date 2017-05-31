using System;
using Plugin.Xablu.Walkthrough;
using UIKit;

namespace WalkthroughSample.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var viewIds = new string[] { "walk", "walk0", "walk1", "walk2" };

            CrossWalkthrough.Current.Init(this);

            new MyClass().SetTheme();

            Button.TouchUpInside += (sender, e) =>
            {
                CrossWalkthrough.Current.Show();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
