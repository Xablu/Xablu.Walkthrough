using System;
using Plugin.Xablu.Walkthrough.Themes;
using Splat;

namespace Plugin.Xablu.Walkthrough.Abstractions.Pages
{
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
