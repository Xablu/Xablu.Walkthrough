using System;
using System.Collections.Generic;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Fragments;
using Walker;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class ForestPrimes : IAndroidTheme
    {
        private IList<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public IList<ForestPrimesPage> Pages
        {
            get => pages;
            set => pages = value;
        }

        private WalkthroughViewPagerBaseFragment viewPager = new Defaults.ForestPrimesContainer();
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
                var item = Pages[i];
                var fragment = new ForestPrimeFragment();
                fragment.Title = item.Title;

                fragments[i] = fragment;
            }
            return fragments;
        }
    }
}
