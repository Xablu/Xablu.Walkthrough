using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Abstractions;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class IWalkthroughExtensions
    {
        public static void Init(this IWalkthrough walkThrough, UIViewController hostViewController)
        {
            var iosWalkThrough = (WalkthroughImplementation)walkThrough;
            iosWalkThrough.Init(hostViewController);
        }
    }
}
