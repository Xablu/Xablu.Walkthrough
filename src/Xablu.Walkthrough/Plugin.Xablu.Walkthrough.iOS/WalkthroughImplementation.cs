using Plugin.Xablu.Walkthrough.Abstractions;
using UIKit;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Themes;
using System;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Implementation for Walkthrough
    /// </summary>
    public class WalkthroughImplementation : IWalkthrough
    {
        private BWWalkthroughViewController _walkthrough;
        private UIViewController _hostViewController;

        private ITheme _theme;
        public ITheme Theme
        {
            get => _theme;
            set
            {
                _theme = value;

                var iosTheme = Theme as IIosTheme;
                _walkthrough = iosTheme.ContainerViewController;
            }
        }

        public void Init(UIViewController hostViewController)
        {
            _hostViewController = hostViewController;
        }

        public void Show()
        {
            //   _hostViewController.PresentViewController(_walkthrough, true, null);
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
            _walkthrough.Close();
        }
    }
}