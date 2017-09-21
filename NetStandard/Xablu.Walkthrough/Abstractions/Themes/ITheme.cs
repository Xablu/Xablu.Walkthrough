using System;
using System.Collections.Generic;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;

namespace Plugin.Xablu.Walkthrough.Abstractions.Themes
{
    public interface ITheme<TPage, TContainer> where TPage : IPage where TContainer : IContainer
    {
        List<TPage> Pages { get; set; }
        TContainer Container { get; set; }
    }
}