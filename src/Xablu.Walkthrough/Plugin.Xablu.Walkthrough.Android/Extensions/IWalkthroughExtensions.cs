using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Plugin.Xablu.Walkthrough.Abstractions;
using Plugin.Xablu.Walkthrough.Defaults;
using Walker;

namespace Plugin.Xablu.Walkthrough
{
    public static class IWalkthroughExtensions
    {
        public static void Init(this IWalkthrough walkThrough, AppCompatActivity hostActivity)
        {
            var androidWalkThrough = (WalkthroughImplementation)walkThrough;
            androidWalkThrough.Init(hostActivity);
        }

        public static void Init(this IWalkthrough walkThrough, WalkerFragment[] fragments, AppCompatActivity hostActivity)
        {
            var androidWalkThrough = (WalkthroughImplementation)walkThrough;
            androidWalkThrough.Init<ViewPagerDialogFragment>(fragments, hostActivity);
        }

        public static void Init<T>(this IWalkthrough walkThrough, WalkerFragment[] fragments, AppCompatActivity hostActivity) where T : WalkthroughViewPagerBaseFragment, new()
        {
            var androidWalkThrough = (WalkthroughImplementation)walkThrough;
            androidWalkThrough.Init<T>(fragments, hostActivity);
        }
    }
}
