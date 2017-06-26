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
        private WalkerFragment[] fragments;
        private AppCompatActivity hostActivity;
        private ViewPager.IOnPageChangeListener listener;

        public int Page = 0;

        public abstract ViewPager ViewPager { get; set; }
        public abstract void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager);

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
            InitializeAdapter(fragments, ChildFragmentManager);
            ViewPager.AddOnPageChangeListener(listener);
        }

        public virtual void SetAdapter(WalkerFragment[] fragments, AppCompatActivity hostActivity)
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