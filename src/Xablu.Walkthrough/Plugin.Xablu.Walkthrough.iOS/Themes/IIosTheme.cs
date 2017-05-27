using System;
using BWWalkthrough;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public interface IIosTheme : ITheme
    {
        BWWalkthroughViewController ContainerViewController { get; set; }
    }
}
