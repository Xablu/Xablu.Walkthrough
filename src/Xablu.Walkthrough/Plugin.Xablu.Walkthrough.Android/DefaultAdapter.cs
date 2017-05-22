using System;
using Android.Support.V4.App;
using Walker;

namespace Plugin.Xablu.Walkthrough
{
    public class DefaultAdapter : FragmentStatePagerAdapter
    {
        private WalkerFragment[] fragments;

        public DefaultAdapter(WalkerFragment[] fragments, Android.Support.V4.App.FragmentManager supportFragmentManager) : base(supportFragmentManager)
        {
            this.fragments = fragments;
        }

        public override int Count => fragments.Length;

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return fragments[position];
        }
    }
}
