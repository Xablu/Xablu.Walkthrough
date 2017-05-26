using System;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Extensions;
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

            var instance = CrossWalkthrough.Current;
            instance.Init(UIStoryboard.FromName("Walkthrough", null), viewIds, this);

            Button.TouchUpInside += (sender, e) =>
            {
                instance.Show();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
