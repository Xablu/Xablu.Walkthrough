using Android.App;
using Android.Widget;
using Android.OS;
using WalkthroughSample.Droid.Fragments;
using Walker;
using Plugin.Walkthrough;

namespace WalkthroughSample.Droid
{
    [Activity(Label = "WalkthroughSample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
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

            instance.Init();
        }
    }
}

