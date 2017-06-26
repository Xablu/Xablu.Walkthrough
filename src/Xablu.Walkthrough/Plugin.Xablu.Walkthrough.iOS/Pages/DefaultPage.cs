using System.Drawing;
using BWWalkthrough;
using Foundation;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Splat;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public abstract class DefaultPage : UIViewController, IBWWalkthroughPage, IDefaultPage
    {
        public virtual Color BackgroundColor { get; set; } = Color.White;

        public virtual TextControl TitleControl { get; set; }

        public virtual ImageControl ImageControl { get; set; }

        public virtual TextControl DescriptionControl { get; set; }

        public DefaultPage(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = BackgroundColor.ToNative();
        }

        public virtual void WalkThroughDidScroll(float position, float offset)
        {
        }
    }
}

