using Android.App;
using Android.OS;
using WalkthroughSample.Droid.Fragments;
using Walker;
using Plugin.Xablu.Walkthrough;
using Android.Support.V7.App;
using Android.Widget;

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

            CrossWalkthrough.Current.Init(this);

            var button = FindViewById<Button>(Resource.Id.showWalkthrough);
            button.Click += async (sender, e) =>
            {
                await new MyClass().SetTheme();
            };
        }
    }
}

