using System;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Walker;

namespace Plugin.Xablu.Walkthrough
{
    public abstract class WalkthroughViewPagerBaseFragment : DialogFragment
    {
        public abstract ViewPager ViewPager{ get; }
        public abstract void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager);

        private WalkerFragment[] fragments;
		private AppCompatActivity hostActivity;
		private ViewPager.IOnPageChangeListener listener;

        public WalkthroughViewPagerBaseFragment(){}

        public static T NewInstance<T>() where T : WalkthroughViewPagerBaseFragment, new()
		{
			Bundle args = new Bundle();
			var fragment = new T();
			fragment.Arguments = args;
			return fragment;
		}

		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetStyle(StyleNoTitle, Android.Resource.Style.ThemeHoloLight);
		}

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            InitializeAdapter(fragments,ChildFragmentManager);
			ViewPager.AddOnPageChangeListener(listener);
        }

		public void SetAdapter(WalkerFragment[] fragments, AppCompatActivity hostActivity)
		{
			this.fragments = fragments;
			this.hostActivity = hostActivity;
		}

		public void SetListener(ViewPager.IOnPageChangeListener listener)
		{
			this.listener = listener;
		}
    }
}
