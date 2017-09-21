using System;
using System.Drawing;
using BWWalkthrough;
using Foundation;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public partial class ForestPrimesContainer : DefaultContainer, IForestPrimesContainer, IBWWalkthroughViewControllerDelegate, IContainer
    {
        private ImageButtonControl nextButtonControl = new ImageButtonControl()
        {
            ClickAction = () =>
            {
                CrossWalkthrough.Current.Next();
            }
        };

        public ImageButtonControl NextButtonControl
        {
            get => nextButtonControl;
            set => nextButtonControl = value;
        }

        private ButtonControl skipButtonControl = new ButtonControl()
        {
            Text = "SKIP",
            ClickAction = () =>
            {
                CrossWalkthrough.Current.Close();
            }
        };

        public ButtonControl SkipButtonControl
        {
            get => skipButtonControl;
            set => skipButtonControl = value;
        }

        private ButtonControl startButtonControl = new ButtonControl()
        {
            Text = "Next",
            ClickAction = () =>
            {
                CrossWalkthrough.Current.Close();
            }
        };

        public ButtonControl StartButtonControl
        {
            get => startButtonControl;
            set => startButtonControl = value;
        }

        public ForestPrimesContainer() : base("ForestPrimesContainer", null)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            Scrollview.Bounces = false;

            StartButton.SetControl(startButtonControl);
            SkipButton.SetControl(skipButtonControl);
            await NextButton.SetControl(nextButtonControl);

            NextButton.AccessibilityIdentifier = "btnNext";
            SkipButton.AccessibilityIdentifier = "btnSkip";
            StartButton.AccessibilityIdentifier = "btnStart";

            walkDelegate = this;

            StartButton.Hidden = true;

            base.PageControl = PageControl;
            base.PageControl.SetControl(CirclePageControl);
            base.PageControl.Enabled = false;
        }

        [Export("scrollViewDidScroll:")]
        public override void Scrolled(UIScrollView scrollView)
        {
            for (int i = 0; i < Controllers.Count; i++)
            {
                var vc = (IBWWalkthroughPage)Controllers[i];

                var pageWidth = View.Bounds.Size.Width;
                var offset = Scrollview.ContentOffset.X;
                var currentPage = offset / pageWidth;

                if (currentPage >= Controllers.Count - 2) //second to last
                {
                    var alphaValue = 1 - (currentPage - (int)currentPage) * 2;

                    if (currentPage == Controllers.Count - 1)
                    {

                        NextButton.Hidden = true;
                        StartButton.Hidden = false;
                        return;
                    }
                    if (alphaValue >= 0)
                    {
                        NextButton.Hidden = false;
                        StartButton.Hidden = true;
                        NextButton.Alpha = alphaValue;
                    }
                    else
                    {
                        NextButton.Hidden = true;
                        StartButton.Hidden = false;
                        StartButton.Alpha = 1 - (alphaValue + 1);
                    }

                }
                if (vc != null)
                {
                    var mx = ((Scrollview.ContentOffset.X + View.Bounds.Size.Width) - (View.Bounds.Size.Width * (i))) / View.Bounds.Size.Width;
                    if (mx < 2 && mx > -2.0)
                    {
                        vc.WalkThroughDidScroll((float)Scrollview.ContentOffset.X, (float)mx);
                    }
                }
            }
        }

        public void WalkthroughCloseButtonPressed()
        {
        }

        public void WalkthroughNextButtonPressed()
        {
        }

        public void WalkthroughPrevButtonPressed()
        {
        }

        public void WalkthroughPageDidChange(int pageNumber)
        {
        }
    }
}

