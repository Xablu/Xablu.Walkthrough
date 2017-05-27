using System;
using System.Collections.Generic;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.ViewControllers;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class ForestPrimes : IIosTheme
    {
        private IList<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public IList<ForestPrimesPage> Pages
        {
            get => (ContainerViewController as ForestPrimesContainerViewController).Pages;
            set => (ContainerViewController as ForestPrimesContainerViewController).Pages = value;
        }

        public BWWalkthroughViewController ContainerViewController { get; set; } = new ForestPrimesContainerViewController();
    }
}
