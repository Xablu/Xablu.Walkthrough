using System;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public partial class VestaContainer : DefaultContainer, IVestaContainer
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

            base.PageControl = PageControl;
            base.PageControl.SetControl(CirclePageControl);

            StartButton.SetControl(GetStartedButtonControl);
        }
    }
}

