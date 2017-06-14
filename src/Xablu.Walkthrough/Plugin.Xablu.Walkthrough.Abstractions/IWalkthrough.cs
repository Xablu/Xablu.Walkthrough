using System;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Pages;
using Plugin.Xablu.Walkthrough.Themes;

namespace Plugin.Xablu.Walkthrough.Abstractions
{
    /// <summary>
    /// Interface for Walkthrough
    /// </summary>
    public interface IWalkthrough
    {
        void Setup<TPage, TContainer>(ITheme<TPage, TContainer> theme) where TPage : IPage where TContainer : IContainer;
        void Show();
        void Next();
        void Previous();
        void Close();
    }
}
