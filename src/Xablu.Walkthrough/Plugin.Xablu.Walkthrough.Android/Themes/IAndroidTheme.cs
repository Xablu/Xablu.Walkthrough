using System;
using Walker;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public interface IAndroidTheme : ITheme
    {
        WalkerFragment[] CreateFragments();
        WalkthroughViewPagerBaseFragment ViewPager { get; set; }
    }
}
