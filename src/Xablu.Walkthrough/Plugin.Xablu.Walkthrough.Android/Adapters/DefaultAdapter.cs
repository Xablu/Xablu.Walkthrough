using Android.Support.V4.App;
using Walker;

namespace Plugin.Xablu.Walkthrough.Defaults
{
    public class DefaultAdapter : FragmentPagerAdapter
    {
        private WalkerFragment[] fragments = new WalkerFragment[0];

        public DefaultAdapter(WalkerFragment[] fragments, FragmentManager supportFragmentManager) :
            base(supportFragmentManager)
        {
            this.fragments = fragments;
        }

        public override int Count => fragments.Length;

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }
    }
}