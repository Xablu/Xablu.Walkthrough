using System;
using Plugin.Xablu.Walkthrough.Extensions;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public partial class OvuPage : DefaultPage
    {
        public OvuPage() : base("OvuPage", null)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title.SetControl(TitleControl);

            await Image.SetControl(ImageControl);

            Description.SetControl(DescriptionControl);
        }
    }
}

