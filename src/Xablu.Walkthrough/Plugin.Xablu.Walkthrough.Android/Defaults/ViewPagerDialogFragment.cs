using System;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Walker;

namespace Plugin.Xablu.Walkthrough.Defaults
{
    public class ViewPagerDialogFragment : WalkthroughViewPagerBaseFragment
    {
        private ViewPager viewPager;
        public override ViewPager ViewPager => viewPager;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.DefaultViewPagerLayout, container, false);
            viewPager = (ViewPager)view.FindViewById(Resource.Id.view_pager);

			var leftButton = (ImageView)view.FindViewById(Resource.Id.left);
            var rightButton = (ImageView)view.FindViewById(Resource.Id.right);

			leftButton.Click += (s, e) =>
			{
                CrossWalkthrough.Current.Next();
			};

			rightButton.Click += (s, e) =>
			{
                CrossWalkthrough.Current.Previous();
			};
			
            return view;
        }

        public override void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager)
        {
            viewPager.Adapter = new DefaultAdapter(fragments, manager);
        }
    }
}
