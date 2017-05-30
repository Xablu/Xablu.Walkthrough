using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Defaults;
using Walker;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class ForestPrimesContainer : WalkthroughViewPagerBaseFragment
    {
        private ViewPager viewPager;
        public override ViewPager ViewPager => viewPager;

        private bool hideBottomNavigation = false;
        public bool HideBottomNavigation
        {
            get => hideBottomNavigation;
            set
            {
                hideBottomNavigation = value;
                if (hideBottomNavigation)
                {
                    bottomNavigation.Visibility = ViewStates.Gone;
                    tabLayout.Visibility = ViewStates.Gone;
                }
                else
                {
                    bottomNavigation.Visibility = ViewStates.Visible;
                    tabLayout.Visibility = ViewStates.Visible;
                }
            }
        }

        private LinearLayout bottomNavigation;
        private TabLayout tabLayout;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_forestprime_container, container, false);
            viewPager = (ViewPager)view.FindViewById(Resource.Id.view_pager);

            bottomNavigation = view.FindViewById<LinearLayout>(Resource.Id.theme_forestprime_bottomlayout);

            tabLayout = view.FindViewById<TabLayout>(Resource.Id.theme_forestprime_tablayout);
            tabLayout.SetupWithViewPager(viewPager, false);

            var skipButton = view.FindViewById<Button>(Resource.Id.theme_forestprime_skip);
            skipButton.Click += (sender, e) =>
            {
                CrossWalkthrough.Current.Close();
            };

            var nextButton = view.FindViewById<AppCompatImageButton>(Resource.Id.theme_forestprime_next);
            nextButton.Click += (sender, e) =>
            {
                CrossWalkthrough.Current.Next();
            };

            return view;
        }

        public override void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager)
        {
            viewPager.Adapter = new DefaultAdapter(fragments, manager);
        }
    }
}
