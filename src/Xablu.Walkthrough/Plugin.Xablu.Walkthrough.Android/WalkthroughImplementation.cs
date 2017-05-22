using Plugin.Walkthrough.Abstractions;
using System;
using Android.Support.V4.View;
using Android.Content;
using Walker;
using Android.App;
using Android.Support.V7.App;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class WalkthroughImplementation : Java.Lang.Object, ViewPager.IOnPageChangeListener, IWalkthrough
    {
        private ViewPager _viewPager;
        private int _currentPosition = 0;

        public void Init(ViewPager viewPager, WalkerFragment[] fragments, AppCompatActivity hostActivity)
        {
            _viewPager = viewPager;
            _viewPager.Adapter = new DefaultAdapter(fragments, hostActivity.SupportFragmentManager);

            foreach (WalkerFragment fragment in fragments)
                _viewPager.AddOnPageChangeListener(fragment);

            _viewPager.AddOnPageChangeListener(this);
        }

        public void Next()
        {
            _viewPager.CurrentItem = _currentPosition - 1;
        }

        public void Previous()
        {
            _viewPager.CurrentItem = _currentPosition + 1;
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
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