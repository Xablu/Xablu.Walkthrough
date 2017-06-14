using Plugin.Xablu.Walkthrough.Abstractions;
using UIKit;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Themes;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Pages;
using System;
using Plugin.Xablu.Walkthrough.Abstractions.Themes;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using System.Collections.Generic;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Implementation for Walkthrough
    /// </summary>
    public class WalkthroughImplementation : IWalkthrough
    {
        private BWWalkthroughViewController _walkthrough;
        private UIViewController _hostViewController;

        public void Setup<TPage, TContainer>(ITheme<TPage, TContainer> theme) where TPage : IPage where TContainer : IContainer
        {
            _walkthrough = theme.Container as BWWalkthroughViewController;

            foreach (var page in theme.Pages)
            {
                var uiPage = page as UIViewController;
                uiPage.View.Bounds = UIScreen.MainScreen.Bounds;
                uiPage.View.SetNeedsLayout();
                uiPage.View.LayoutIfNeeded();

                _walkthrough.AddViewController(uiPage);
            }
        }

        public void Init(UIViewController hostViewController)
        {
            _hostViewController = hostViewController;
        }

        public void Show()
        {
            _hostViewController.PresentViewController(_walkthrough, true, null);
        }

        public void Next()
        {
            _walkthrough.NextPage();
        }

        public void Previous()
        {
            _walkthrough.PreviousPage();
        }

        public void Close()
        {
            _walkthrough.DismissViewController(true, null);
            _walkthrough.Close();
        }
    }
}