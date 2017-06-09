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

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            CrossWalkthrough.Current.Init(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


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
