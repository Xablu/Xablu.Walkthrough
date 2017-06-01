using System;
using Plugin.Xablu.Walkthrough.Extensions;
using Plugin.Xablu.Walkthrough.Pages;
using Splat;
using UIKit;

namespace Plugin.Xablu.Walkthrough.ViewControllers
{
    public partial class ForestPrimesViewController : UIViewController
    {
        public ForestPrimesPage Page
        {
            get;
            set;
        }

        public ForestPrimesViewController() : base("ForestPrimesViewController", null)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = Page.BackgroundColor.ToNative();

            //Title
            Title.SetValues(Page.TitleControl);
            await CenterImage.SetValues(Page.CenterImage);
            Description.SetValues(Page.DescriptionControl);

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

