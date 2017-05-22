using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Plugin.Walkthrough.Abstractions;
using Walker;

namespace Plugin.Xablu.Walkthrough
{
    public static class IWalkthroughExtensions
    {
        public static void Init(this IWalkthrough walkThrough, Android.Support.V4.View.ViewPager viewPager, WalkerFragment[] fragments, AppCompatActivity hostActivity)
        {
            var androidWalkThrough = (WalkthroughImplementation)walkThrough;
            androidWalkThrough.Init(viewPager, fragments, hostActivity);
        }
    }
}
