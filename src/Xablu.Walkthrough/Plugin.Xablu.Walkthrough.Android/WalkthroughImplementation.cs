using Plugin.Xablu.Walkthrough.Abstractions;
using System;
using Android.Support.V4.View;
using Android.Content;
using Walker;
using Android.App;
using Android.Support.V7.App;
using Android.Views;
using Plugin.Xablu.Walkthrough.Defaults;
using Plugin.Xablu.Walkthrough.Themes;
using Android.Graphics.Drawables;

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

        private ITheme _theme;
        public ITheme Theme
        {
            get => _theme;
            set
            {
                _theme = value;

                var androidTheme = Theme as IAndroidTheme;
                _viewPagerFragment = androidTheme.ViewPager;
                _viewPagerFragment.SetAdapter(androidTheme.CreateFragments(), _hostActvity);
                _viewPagerFragment.SetListener(this);
            }
        }

        public void Init(AppCompatActivity hostActivity)
        {
            _hostActvity = hostActivity;
        }

        public void Previous()
        {
            _viewPagerFragment.ViewPager.CurrentItem = _currentPosition - 1;
        }

        public void Next()
        {
            _viewPagerFragment.ViewPager.CurrentItem = _currentPosition + 1;
        }

        public void Show()
        {
            _viewPagerFragment.Show(_hostActvity.SupportFragmentManager, Class.SimpleName);
        }

        public void Close()
        {
            _viewPagerFragment.ViewPager.CurrentItem = 0;
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