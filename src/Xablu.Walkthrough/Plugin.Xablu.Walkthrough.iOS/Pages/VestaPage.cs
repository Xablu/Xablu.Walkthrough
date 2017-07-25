using System;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Extensions;
using Splat;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public partial class VestaPage : DefaultPage, IVestaPage
    {
        public VestaPage() : base("VestaPage", null)
        {
        }

        public ImageControl BackgroundImage { get; set; }
        public bool FadeBackgroundToBlack { get; set; }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title.SetControl(TitleControl);

            await Image.SetControl(ImageControl);

            Description.SetControl(DescriptionControl);
        }
    }
}

