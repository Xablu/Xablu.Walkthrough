using Plugin.Walkthrough.Abstractions;
using System;
using Android.Support.V4.View;
using Android.Content;
using Walker;

namespace Plugin.Walkthrough
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class WalkthroughImplementation : Java.Lang.Object, ViewPager.IOnPageChangeListener, IWalkthrough
    {
        private ViewPager _viewPager;
        private int _currentPosition = 0;

        public void Init(ViewPager viewPager, WalkerFragment[] fragments, Context context)
        {
            _viewPager = viewPager;
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