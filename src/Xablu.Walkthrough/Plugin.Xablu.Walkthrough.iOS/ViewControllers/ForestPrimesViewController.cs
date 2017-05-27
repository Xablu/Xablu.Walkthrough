using System;

using UIKit;

namespace Plugin.Xablu.Walkthrough.ViewControllers
{
    public partial class ForestPrimesViewController : UIViewController
    {
        public string PageTitle
        {
            get;
            set;
        }

        public ForestPrimesViewController() : base("ForestPrimesViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            lblTitle.Text = PageTitle;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

