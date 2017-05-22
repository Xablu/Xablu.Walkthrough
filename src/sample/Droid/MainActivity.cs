using Android.App;
using Android.OS;
using WalkthroughSample.Droid.Fragments;
using Walker;
using Plugin.Walkthrough;
using Android.Support.V7.App;
using Plugin.Xablu.Walkthrough;

namespace WalkthroughSample.Droid
{
    [Activity(Label = "WalkthroughSample", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var instance = CrossWalkthrough.Current;

            var fragments = new WalkerFragment[] {
                WalkerFragment.NewInstance<FirstPageFragment>(),
                WalkerFragment.NewInstance<SecondPageFragment>(),
                WalkerFragment.NewInstance<ThirdPageFragment>()
            };

            var viewPager = (Android.Support.V4.View.ViewPager)FindViewById(Resource.Id.view_pager);

            instance.Init(viewPager, fragments, this);
        }
    }
}

