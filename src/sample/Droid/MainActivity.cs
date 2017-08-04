using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Plugin.Xablu.Walkthrough;

namespace WalkthroughSample.Droid
{
    [Activity(Label = "WalkthroughSample", MainLauncher = true, Icon = "@drawable/icon",
        Theme = "@style/Theme.AppCompat")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            CrossWalkthrough.Current.Init(this);

            FindViewById<Button>(Resource.Id.showWalk).Click += (sender, e) => ForestPrimesSamples.ShowForestContainerForestPage();
            FindViewById<Button>(Resource.Id.showWalk2).Click += (sender, e) => PantheonSamples.ShowPantheonContainerForestPage();
            FindViewById<Button>(Resource.Id.showWalk3).Click += (sender, e) => VestaSamples.ShowVestaContainerVestaPage();
            FindViewById<Button>(Resource.Id.showWalk4).Click += (sender, e) => VestaAltSamples.ShowVestaAltContainerVestaPage();
            FindViewById<Button>(Resource.Id.showWalk5).Click += (sender, e) => ForestPrimesSamples.ShowForestContainerOvuPage();
        }
    }
}