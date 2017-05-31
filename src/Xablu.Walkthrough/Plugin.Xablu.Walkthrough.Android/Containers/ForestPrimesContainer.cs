using System;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Defaults;
using Splat;
using Walker;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class ForestPrimesContainer : WalkthroughViewPagerBaseFragment, ViewPager.IOnPageChangeListener
    {
        private ViewPager viewPager;
        public override ViewPager ViewPager => viewPager;

        public AppCompatImageButton NextButton;
        public TextView StartTextButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_forestprime_container, container, false);
            viewPager = (ViewPager)view.FindViewById(Resource.Id.view_pager);
            viewPager.SetOnPageChangeListener(this);

            var bottomNavigation = view.FindViewById<LinearLayout>(Resource.Id.theme_forestprime_bottomlayout);

            var tabLayout = view.FindViewById<TabLayout>(Resource.Id.theme_forestprime_tablayout);
            tabLayout.SetupWithViewPager(viewPager, false);

            var skipButton = view.FindViewById<Button>(Resource.Id.theme_forestprime_skip);
            skipButton.Click += (sender, e) =>
            {
                CrossWalkthrough.Current.Close();
            };

            NextButton = view.FindViewById<AppCompatImageButton>(Resource.Id.theme_forestprime_next);
            NextButton.Click += (sender, e) =>
            {
                CrossWalkthrough.Current.Next();
            };

            StartTextButton = view.FindViewById<TextView>(Resource.Id.theme_forestprime_start);
            return view;
        }

        public override void InitializeAdapter(WalkerFragment[] fragments, FragmentManager manager)
        {
            viewPager.Adapter = new DefaultAdapter(fragments, manager);
        }

        public void SetFinalizeTextView(ButtonControl buttonControl)
        {
            StartTextButton.Click += (sender, e) =>
            {
                buttonControl.ClickAction();
            };

            StartTextButton.Text = buttonControl.Text;
            StartTextButton.TextSize = buttonControl.TextSize;
            StartTextButton.SetTextColor(buttonControl.TextColor.ToNative());
        }


        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
            if (position != ViewPager.Adapter.Count - 1) //has final page
            {
                if (ViewPager.Adapter.Count - 2 == position)
                {
                    float alpha = 1;

                    if (positionOffset >= 0.5)
                    {
                        StartTextButton.Visibility = ViewStates.Visible;
                        float startAplha = (positionOffset - 0.5f) * 2; // fadein
                        StartTextButton.Alpha = startAplha;
                        NextButton.Alpha = 0;
                    }
                    else
                    {
                        alpha = 1 - (positionOffset * 2); // fadeout
                        NextButton.Alpha = alpha;
                        StartTextButton.Alpha = 0;
                        StartTextButton.Visibility = ViewStates.Gone;
                    }
                }
            }
        }

        public void OnPageSelected(int position)
        {

        }
    }
}
