using UIKit;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Themes;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Abstractions;
using System;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Implementation for iOS
    /// </summary>
    public class WalkthroughImplementation : IWalkthrough
    {
        private BWWalkthroughViewController walkthrough;
        private UIViewController hostViewController;

        public bool IsInitialized { get; set; } = false;
        public int Page { get; set; } = 0;

        public void Setup<TPage, TContainer>(ITheme<TPage, TContainer> theme) where TPage : IPage where TContainer : IContainer
        {
            walkthrough = theme.Container as BWWalkthroughViewController;
            if(walkthrough != null)
            {
				foreach (var page in theme?.Pages)
				{
					var uiPage = page as UIViewController;
					if (uiPage != null)
					{
						uiPage.View.Bounds = UIScreen.MainScreen.Bounds;
						uiPage.View.SetNeedsLayout();
						uiPage.View.LayoutIfNeeded();

						walkthrough.AddViewController(uiPage);
					}
				}

				IsInitialized = true;
            }
        }

        public void Init(UIViewController hostVc)
        {
            hostViewController = hostVc;
        }

        public void Show()
        {
            walkthrough.CurrentPage = Page;
            hostViewController.PresentViewController(walkthrough, true, null);
        }

        public void Next()
        {
            walkthrough.NextPage();
        }

        public void Previous()
        {
            walkthrough.PreviousPage();
        }

        public void Close()
        {
            walkthrough.DismissViewController(true, null);
            walkthrough.Close();
        }
    }
}