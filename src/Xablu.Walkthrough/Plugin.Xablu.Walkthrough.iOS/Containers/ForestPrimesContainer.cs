using System;
using System.Collections.Generic;
using BWWalkthrough;
using Foundation;
using Plugin.Xablu.Walkthrough.Pages;
using Plugin.Xablu.Walkthrough.ViewControllers;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public partial class ForestPrimesContainer : BWWalkthroughViewController
    {
        private List<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public List<ForestPrimesPage> Pages
        {
            get => pages;
            set => pages = value;
        }

        public ForestPrimesContainer() : base("ForestPrimesContainer", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            for (int i = 0; i < Pages.Count; i++)
            {
                var page = new ForestPrimesViewController();
                page.Page = Pages[i];
                AddViewController(page);
            }

            NextButton.TouchUpInside += (sender, e) =>
            {
                CrossWalkthrough.Current.Next();
            };

            SkipButton.TouchUpInside += (sender, e) =>
            {
                CrossWalkthrough.Current.Close();
            };

            base.PageControl = PageControl;

            PageControl.PageIndicatorTintColor = UIColor.FromRGB(236, 104, 128);
            PageControl.CurrentPageIndicatorTintColor = UIColor.FromRGB(237, 26, 59);
        }

        [Export("scrollViewDidScroll:")]
        public void Scrolled(UIScrollView scrollView)
        {
            // base.Scrolled(scrollView);

            for (int i = 0; i < Controllers.Count; i++)
            {
                var vc = Controllers[i] as IBWWalkthroughPage;


                var pageWidth = View.Bounds.Size.Width;
                var offset = Scrollview.ContentOffset.X;
                var currentPage = offset / pageWidth;

                if (currentPage >= Controllers.Count - 2) //second to last
                {
                    var alphaValue = 1 - (currentPage - (int)currentPage) * 2;
                    if (alphaValue >= 0)
                    {
                        NextButton.Alpha = alphaValue;
                    }
                    else
                    {
                        NextButton.Alpha = 1 - (alphaValue + 1);
                    }

                    Console.WriteLine($"buttonAlpha:{NextButton.Alpha}, alphaValue:{alphaValue}");
                }
                if (vc != null)
                {
                    var mx = ((Scrollview.ContentOffset.X + View.Bounds.Size.Width) - (View.Bounds.Size.Width * (i))) / View.Bounds.Size.Width;

                    // While sliding to the "next" slide (from right to left), the "current" slide changes its offset from 1.0 to 2.0 while the "next" slide changes it from 0.0 to 1.0
                    // While sliding to the "previous" slide (left to right), the current slide changes its offset from 1.0 to 0.0 while the "previous" slide changes it from 2.0 to 1.0
                    // The other pages update their offsets whith values like 2.0, 3.0, -2.0... depending on their positions and on the status of the walkthrough
                    // This value can be used on the previous, current and next page to perform custom animations on page's subviews.

                    // print the mx value to get more info.
                    //System.Diagnostics.Debug.Print($"{i}:{mx}");

                    // We animate only the previous, current and next page

                    if (mx < 2 && mx > -2.0)
                    {
                        vc.WalkThroughDidScroll((float)Scrollview.ContentOffset.X, (float)mx);
                    }
                }
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void WalkthroughCloseButtonPressed()
        {
            //  throw new NotImplementedException();
        }

        public void WalkthroughNextButtonPressed()
        {
            //  throw new NotImplementedException();
        }

        public void WalkthroughPrevButtonPressed()
        {
            //  throw new NotImplementedException();
        }

        public void WalkthroughPageDidChange(int pageNumber)
        {
            //  throw new NotImplementedException();
        }
    }
}

