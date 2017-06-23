using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public partial class PantheonContainer : DefaultContainer, IPantheonContainer
    {
        public ButtonControl GetStartedButtonControl { get; set; }

        public PantheonContainer() : base("PantheonContainer", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            PageControl = PageControl;
            PageControl.SetControl(CirclePageControl);

            StartButton.SetControl(GetStartedButtonControl);
        }
    }
}

