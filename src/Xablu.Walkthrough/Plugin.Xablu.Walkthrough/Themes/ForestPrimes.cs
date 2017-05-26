using System;
using System.Collections.Generic;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class ForestPrimes : ITheme
    {
        private IList<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public IList<ForestPrimesPage> Pages
        {
            get => pages;
            set => pages = value;
        }
    }
}
