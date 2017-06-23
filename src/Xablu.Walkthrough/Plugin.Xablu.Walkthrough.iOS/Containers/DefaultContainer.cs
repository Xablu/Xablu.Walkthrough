using System;
using System.Drawing;
using BWWalkthrough;
using Foundation;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using Splat;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public abstract class DefaultContainer : BWWalkthroughViewController, IDefaultContainer
    {
        public DefaultContainer(IntPtr handle) : base(handle)
        {}

        public DefaultContainer(NSCoder coder) : base(coder)
        {}

        public DefaultContainer(string nibName, NSBundle bundle) : base(nibName, bundle)
        {}

        public virtual Color BackgroundColor { get; set; } = Color.White;
        public PageControl CirclePageControl { get; set; }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

            View.BackgroundColor = BackgroundColor.ToNative();
		}
    }
}
