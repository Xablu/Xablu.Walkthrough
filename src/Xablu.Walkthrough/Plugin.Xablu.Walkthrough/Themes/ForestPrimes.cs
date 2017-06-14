using System;
using System.Collections.Generic;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Pages;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class ForestPrimes : ITheme
    {
        private List<ForestPrimesPage> pages = new List<ForestPrimesPage>();
        public List<ForestPrimesPage> Pages
        {
            get => pages;
            set => pages = value;
        }

        public IContainer Container { get; set; }
    }
}
