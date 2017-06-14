using Android.Support.V4.App;
using Android.Support.V4.View;
using Plugin.Xablu.Walkthrough.Defaults;
using Walker;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public abstract class BaseContainer : WalkthroughViewPagerBaseFragment
    {
        private ViewPager viewPager;
        public override ViewPager ViewPager
        {
            get => viewPager;
            set => viewPager = value;
        }

        public BaseContainer() { }

        public override void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager)
        {
            ViewPager.Adapter = new DefaultAdapter(fragments, manager);
        }
    }
}
