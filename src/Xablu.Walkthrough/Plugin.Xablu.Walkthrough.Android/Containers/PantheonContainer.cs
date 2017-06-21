using Android.OS;
using Android.Views;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Android.Support.V4.View;
using Splat;
using Plugin.Xablu.Walkthrough.Indicator;
using Plugin.Xablu.Walkthrough.Extensions;
using Android.Widget;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class PantheonContainer : BaseContainer, IPantheonContainer
    {
        public ButtonControl GetStartedButtonControl { get; set; }

        public Color BackgroundColor { get; set; }

        public PageControl CirclePageControl { get; set; }

        private CircleIndicator circleIndicator;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_pantheon_container, container, false);

            if (BackgroundColor != null)
                view.SetBackgroundColor(BackgroundColor.ToNative());

            ViewPager = (ViewPager)view.FindViewById(Resource.Id.view_pager);

            circleIndicator = view.FindViewById<CircleIndicator>(Resource.Id.indicator);
            circleIndicator.SetControl(CirclePageControl);

            var startButton = view.FindViewById<Button>(Resource.Id.theme_pantheon_get_started);
            startButton.SetControl(GetStartedButtonControl);

            return view;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            circleIndicator.SetViewPager(ViewPager);
        }
    }
}
