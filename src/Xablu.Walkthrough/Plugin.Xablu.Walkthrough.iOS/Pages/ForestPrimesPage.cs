using System.Drawing;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Extensions;
using Splat;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public partial class ForestPrimesPage : UIViewController, IBWWalkthroughPage, IPage
    {
        public Color BackgroundColor = Color.PaleGreen;

        public TextControl TitleControl;

        public ImageControl CenterImageControl;

        public TextControl DescriptionControl;

        public ForestPrimesPage() : base("ForestPrimesPage", null)
        {
        }

        public override void ViewDidLayoutSubviews()
        {
            // View.Bounds = UIScreen.MainScreen.Bounds;
            base.ViewDidLayoutSubviews();
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = BackgroundColor.ToNative();

            Title.SetControl(TitleControl);

            await CenterImage.SetControl(CenterImageControl);

            Description.SetControl(DescriptionControl);
        }

        public void WalkThroughDidScroll(float position, float offset)
        {

        }
    }
}

