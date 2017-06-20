using System.Drawing;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Extensions;
using Splat;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public partial class ForestPrimesPage : UIViewController, IBWWalkthroughPage, IForestPrimesPage
    {
        public Color BackgroundColor { get; set; } = Color.White;

        public TextControl TitleControl { get; set; }

        public ImageControl CenterImageControl { get; set; }

        public TextControl DescriptionControl { get; set; }

        public ForestPrimesPage() : base("ForestPrimesPage", null)
        {
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

