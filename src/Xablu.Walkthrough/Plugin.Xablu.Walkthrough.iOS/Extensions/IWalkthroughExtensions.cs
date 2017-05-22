using Plugin.Walkthrough;
using Plugin.Walkthrough.Abstractions;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class IWalkthroughExtensions
    {
        public static void Init(this IWalkthrough walkThrough, UIStoryboard storyBoard, string[] idsViews, UIViewController hostViewController)
        {
            var iosWalkThrough = (WalkthroughImplementation)walkThrough;
            iosWalkThrough.Init(storyBoard,idsViews,hostViewController);
        }
    }
}
