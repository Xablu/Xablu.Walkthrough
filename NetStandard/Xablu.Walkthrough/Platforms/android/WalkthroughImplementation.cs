using Plugin.Xablu.Walkthrough.Abstractions;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Themes;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Walker;
using System;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Implementation for Android
    /// </summary>
    public class WalkthroughImplementation : Java.Lang.Object, ViewPager.IOnPageChangeListener, IWalkthrough
    {
        private WalkthroughViewPagerBaseFragment viewPagerFragment;
        private AppCompatActivity hostActvity;

        public int Page { get; set; }
        public bool IsInitialized { get; set; } = false;


        public void Init(AppCompatActivity hostActivity)
        {
            hostActvity = hostActivity;
        }

        public void Setup<TPage, TContainer>(ITheme<TPage, TContainer> theme)
            where TPage : IPage where TContainer : IContainer
        {
            var androidTheme = theme.Container as DefaultContainer;
            var pages = theme.Pages.ToArray() as WalkerFragment[];

            viewPagerFragment = androidTheme;
            viewPagerFragment.SetAdapter(pages, hostActvity);
            viewPagerFragment.SetListener(this);

            IsInitialized = true;
        }

        public void Previous()
        {
            viewPagerFragment.ViewPager.CurrentItem = Page - 1;
        }

        public void Next()
        {
            viewPagerFragment.ViewPager.CurrentItem = Page + 1;
        }

        public void Show()
        {
            viewPagerFragment.Page = Page;
            viewPagerFragment.Show(hostActvity.SupportFragmentManager, Class.SimpleName);
        }

        public void Close()
        {
            viewPagerFragment.ViewPager.CurrentItem = 0;
            viewPagerFragment.Dismiss();
        }

        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
        }

        public void OnPageSelected(int position)
        {
            Page = position;
        }
    }
}