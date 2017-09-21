using Plugin.Xablu.Walkthrough.Abstractions;
using UIKit;

namespace Plugin.Xablu.Walkthrough
{
    public static class IWalkthroughExtensionsiOS
    {
        public static void Init(this IWalkthrough walkThrough, UIViewController hostViewController)
        {
            var iosWalkThrough = (WalkthroughImplementation)walkThrough;
            iosWalkThrough.Init(hostViewController);
        }
    }
}
