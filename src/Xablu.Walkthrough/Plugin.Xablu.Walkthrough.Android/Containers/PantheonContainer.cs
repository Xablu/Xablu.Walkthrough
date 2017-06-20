using Android.OS;
using Android.Views;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Android.Support.V4.View;
using Splat;
using Plugin.Xablu.Walkthrough.Indicator;
using Plugin.Xablu.Walkthrough.Extensions;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class PantheonContainer : BaseContainer, IPantheonContainer
    {
        public ButtonControl GetStartedButtonControl { get; set; }

        public Color BackgroundColor { get; set; } = Color.Violet;

        public PageControl CirclePageControl { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_pantheon_container, container, false);
            view.SetBackgroundColor(BackgroundColor.ToNative());

            ViewPager = (ViewPager)view.FindViewById(Resource.Id.view_pager);

            var circleIndicator = view.FindViewById<CircleIndicator>(Resource.Id.indicator);
            circleIndicator.SetControl(CirclePageControl);


            return view;
        }
    }
}
