using System;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using System.Drawing;
using Splat;
using Plugin.Xablu.Walkthrough.Indicator;
using Walker;
using Android.Support.V4.App;
using Plugin.Xablu.Walkthrough.Defaults;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public abstract class DefaultContainer : WalkthroughViewPagerBaseFragment
    {
        private ViewPager _viewPager;

        protected abstract int FragmentLayoutId { get; }

        protected virtual int CircleIndicatorResourceId => Resource.Id.indicator;
        protected virtual int ViewPagerResourceId => Resource.Id.view_pager;
        protected virtual CircleIndicator CircleIndicator { get; set; }

        public virtual Color BackgroundColor { get; set; } = Color.White;
        public virtual PageControl CirclePageControl { get; set; }

        public override ViewPager ViewPager
        {
            get => _viewPager;
            set => _viewPager = value;
        }

        public override void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager)
        {
            ViewPager.Adapter = new DefaultAdapter(fragments, manager);
            ViewPager.CurrentItem = Page;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(FragmentLayoutId, container, false);

            view.SetBackgroundColor(BackgroundColor.ToNative());

            ViewPager = (ViewPager)view.FindViewById(ViewPagerResourceId);

            CircleIndicator = view.FindViewById<CircleIndicator>(CircleIndicatorResourceId);
            CircleIndicator.SetControl(CirclePageControl);

            return view;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            CircleIndicator.SetViewPager(ViewPager);
        }
    }
}