using CoreAnimation;
using CoreGraphics;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Extensions;
using UIKit;

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
            Description.SetControl(DescriptionControl);
            await Image.SetControl(ImageControl);
            await BackgroundImageView.SetControl(BackgroundImage);
        }

        public override void ViewWillAppear(bool animated)
        {
            if (FadeBackgroundToBlack)
            {
                var gradient = new CAGradientLayer();
                gradient.Frame = BottomView.Bounds;
                var startColor = UIColor.FromRGBA(0, 0, 0, 0);
                var endColor = UIColor.FromRGBA(0, 0, 0, 220);
                gradient.Colors = new CGColor[] { startColor.CGColor, endColor.CGColor };
                BottomView.Layer.InsertSublayer(gradient, 0);
            }
        }
    }
}

