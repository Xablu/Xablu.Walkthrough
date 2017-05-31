using System.Collections.Generic;
using Plugin.Xablu.Walkthrough.Fragments;
using Plugin.Xablu.Walkthrough.Containers;
using Walker;
using Plugin.Xablu.Walkthrough.Pages;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class ForestPrimes : IAndroidTheme
    {
        public System.Drawing.Color SkipColor { get; set; }
        public System.Drawing.Color NextButtonColor { get; set; }

        private List<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public List<ForestPrimesPage> Pages
        {
            get => pages;
            set => pages = value;
        }

        private WalkthroughViewPagerBaseFragment viewPager = new ForestPrimesContainer();
        public WalkthroughViewPagerBaseFragment ViewPager
        {
            get => viewPager;
            set => viewPager = value;
        }

        public WalkerFragment[] CreateFragments()
        {
            WalkerFragment[] fragments = new WalkerFragment[Pages.Count];

            for (int i = 0; i < Pages.Count; i++)
            {
                var page = Pages[i];
                var fragment = new ForestPrimeFragment();
                fragment.Page = page;
                fragment.Container = ViewPager as ForestPrimesContainer;

                fragments[i] = fragment;
            }
            return fragments;
        }
    }
}
