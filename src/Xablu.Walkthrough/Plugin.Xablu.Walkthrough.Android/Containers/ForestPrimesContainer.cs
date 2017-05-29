using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Plugin.Xablu.Walkthrough.Defaults;
using Walker;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class ForestPrimesContainer : WalkthroughViewPagerBaseFragment
    {
        private ViewPager viewPager;
        public override ViewPager ViewPager => viewPager;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_forestprime_container, container, false);
            viewPager = (ViewPager)view.FindViewById(Resource.Id.view_pager);

            var tabLayout = view.FindViewById<TabLayout>(Resource.Id.tab_layout);
            tabLayout.SetupWithViewPager(viewPager, false);


            //var leftButton = (ImageView)view.FindViewById(Resource.Id.left);
            //var rightButton = (ImageView)view.FindViewById(Resource.Id.right);

            //leftButton.Click += (s, e) =>
            //{
            //    CrossWalkthrough.Current.Next();
            //};

            //rightButton.Click += (s, e) =>
            //{
            //    CrossWalkthrough.Current.Previous();
            //};

            return view;
        }

        public override void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager)
        {
            viewPager.Adapter = new DefaultAdapter(fragments, manager);
        }
    }
}
