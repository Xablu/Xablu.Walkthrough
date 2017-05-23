using Plugin.Walkthrough.Abstractions;
using System;
using Android.Support.V4.View;
using Android.Content;
using Walker;
using Android.App;
using Android.Support.V7.App;
using Android.Views;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class WalkthroughImplementation : Java.Lang.Object, ViewPager.IOnPageChangeListener, IWalkthrough
    {
        private WalkthroughViewPagerBaseFragment _viewPagerFragment;
        private AppCompatActivity _hostActvity;

        private int _currentPosition = 0;
        public bool _isShown = false;

		public void Init(WalkerFragment[] fragments, AppCompatActivity hostActivity)
		{
			_hostActvity = hostActivity;
            setViewPagerFragment(WalkthroughViewPagerBaseFragment.NewInstance<ViewPagerDialogFragment>(), fragments, hostActivity);
		}

        public void Init<T>(WalkerFragment[] fragments, AppCompatActivity hostActivity) where T : WalkthroughViewPagerBaseFragment, new()
        {
            _hostActvity = hostActivity;
            setViewPagerFragment(WalkthroughViewPagerBaseFragment.NewInstance<T>(), fragments, hostActivity);
        }

        private void setViewPagerFragment(WalkthroughViewPagerBaseFragment fragment,WalkerFragment[] fragments, AppCompatActivity hostActivity)
        {
			_viewPagerFragment = WalkthroughViewPagerBaseFragment.NewInstance<ViewPagerDialogFragment>();
			_viewPagerFragment.SetAdapter(fragments, hostActivity);
			_viewPagerFragment.SetListener(this);
        }

        public void Next()
        {
            _viewPagerFragment.ViewPager.CurrentItem = _currentPosition - 1;
        }

        public void Previous()
        {
            _viewPagerFragment.ViewPager.CurrentItem = _currentPosition + 1;
        }

        public void Show()
        {
            _viewPagerFragment.Show(_hostActvity.SupportFragmentManager,Class.SimpleName);
        }

        public void Close()
        {
            _viewPagerFragment.Dismiss();
        }

        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
        }

        public void OnPageSelected(int position)
        {
            _currentPosition = position;
        }
    }
}