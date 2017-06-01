using System;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Extensions;
using Plugin.Xablu.Walkthrough.Pages;
using Splat;
using UIKit;

namespace Plugin.Xablu.Walkthrough.ViewControllers
{
    public partial class ForestPrimesViewController : UIViewController, IBWWalkthroughPage
    {
        public ForestPrimesPage Page
        {
            get;
            set;
        }

        public ForestPrimesContainer Container { get; set; }

        public ForestPrimesViewController() : base("ForestPrimesViewController", null)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = Page.BackgroundColor.ToNative();

            Title.SetValues(Page.TitleControl);

            await CenterImage.SetValues(Page.CenterImage);

            Description.SetValues(Page.DescriptionControl);

            if (Page.FinishedButton != null)
                Container.SetFinishedButton(Page.FinishedButton);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void WalkThroughDidScroll(float position, float offset)
        {

        }
    }
}

