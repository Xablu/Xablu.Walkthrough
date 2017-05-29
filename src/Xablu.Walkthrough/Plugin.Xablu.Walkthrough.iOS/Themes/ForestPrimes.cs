using System.Collections.Generic;
using BWWalkthrough;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Pages;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class ForestPrimes : IIosTheme
    {
        private IList<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public IList<ForestPrimesPage> Pages
        {
            get => (ContainerViewController as ForestPrimesContainer).Pages;
            set => (ContainerViewController as ForestPrimesContainer).Pages = value;
        }

        public BWWalkthroughViewController ContainerViewController { get; set; } = new ForestPrimesContainer();
    }
}
