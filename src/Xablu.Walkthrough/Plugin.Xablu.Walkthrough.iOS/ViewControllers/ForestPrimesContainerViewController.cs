using System;
using System.Collections.Generic;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using UIKit;

namespace Plugin.Xablu.Walkthrough.ViewControllers
{
    public partial class ForestPrimesContainerViewController : BWWalkthroughViewController
    {
        private IList<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public IList<ForestPrimesPage> Pages
        {
            get => pages;
            set => pages = value;
        }

        public ForestPrimesContainerViewController() : base("ForestPrimesContainerViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            pageControl = new UIPageControl();
            //base.nextButton = new UIPageControl();
            //base.prevButton = new UIPageControl();


            base.ViewDidLoad();

            for (int i = 0; i < Pages.Count; i++)
            {
                var page = new ForestPrimesViewController();
                page.PageTitle = Pages[i].Title;
                AddViewController(page);
            }


            this.NextPage();



            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

