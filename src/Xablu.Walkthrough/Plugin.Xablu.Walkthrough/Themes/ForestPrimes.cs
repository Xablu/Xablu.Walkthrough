using System;
using System.Collections.Generic;
using Splat;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class ForestPrimes : BaseTheme<ForestPrimesPage>
    {
        private IEnumerable<ForestPrimesPage> pages = new List<ForestPrimesPage>();

        public override IEnumerable<ForestPrimesPage> Pages
        {
            get => pages;
            set => pages = value;
        }
    }

    public class ForestPrimesPage : IPage
    {
        public string Title
        {
            get;
            set;
        }

        public IBitmap CenterImage
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public IBitmap PreviousButton
        {
            get;
            set;
        }

        public IBitmap NextButton
        {
            get;
            set;
        }
    }
}
