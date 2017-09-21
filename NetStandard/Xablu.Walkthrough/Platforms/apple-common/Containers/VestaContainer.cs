using System;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public partial class VestaContainer : DefaultContainer, IVestaContainer, IBWWalkthroughViewControllerDelegate
    {
        public ButtonControl PreviousButtonControl { get; set; }
        public ButtonControl NextButtonControl { get; set; }
        public ButtonControl FirstPagePreviousButtonControl { get; set; }
        public ButtonControl LastPageNextButtonControl { get; set; }
        public ButtonControl GetStartedButtonControl { get; set; }

        public VestaContainer() : base("VestaContainer", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            walkDelegate = this;

            base.PageControl = PageControl;
            base.PageControl.SetControl(CirclePageControl);

            StartButton.SetControl(GetStartedButtonControl);

            PreviousButton.SetControl(FirstPagePreviousButtonControl ?? PreviousButtonControl, false);
            PreviousButton.TouchUpInside += (sender, e) => PreviousButtonClicked();

            NextButton.SetControl(NextButtonControl ?? LastPageNextButtonControl, false);
            NextButton.TouchUpInside += (sender, e) => NextButtonClicked();
        }

        private void PreviousButtonClicked()
        {
            PreviousButton.Hidden = true;

            if (FirstPagePreviousButtonControl != null && PageControl.CurrentPage == 0)
            {
                FirstPagePreviousButtonControl.ClickAction?.Invoke();
                return;
            }

            PreviousButtonControl?.ClickAction?.Invoke();
        }

        private void NextButtonClicked()
        {
            NextButton.Hidden = true;

            if (LastPageNextButtonControl != null && PageControl.CurrentPage == PageControl.Pages - 1)
            {
                LastPageNextButtonControl.ClickAction?.Invoke();
                return;
            }

            NextButtonControl?.ClickAction?.Invoke();
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
            if (pageNumber == 0)
                PreviousButton.SetControl(FirstPagePreviousButtonControl ?? PreviousButtonControl, false);
            else
                PreviousButton.SetControl(PreviousButtonControl, false);

            if (pageNumber == PageControl.Pages - 1)
                NextButton.SetControl(LastPageNextButtonControl ?? NextButtonControl, false);
            else
                NextButton.SetControl(NextButtonControl, false);
        }
    }
}

