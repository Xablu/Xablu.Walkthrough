using Plugin.Walkthrough.Abstractions;
using Plugin.Xablu.Walkthrough.Themes;

namespace Plugin.Xablu.Walkthrough
{
    public static class IWalkthroughExtensions
    {
        public static T Init<T>(this IWalkthrough walkThrough) where T : ITheme, new()
        {
            return new T();
        }
    }
}
