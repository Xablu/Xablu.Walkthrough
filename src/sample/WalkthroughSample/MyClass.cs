using System;
using System.Collections.Generic;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Themes;
using System.Linq;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;

namespace WalkthroughSample
{
    public class MyClass
    {
        public MyClass()
        {
            var theme = new ForestPrimes();
            theme.Pages.Add(
                new ForestPrimesPage()
                {
                    Title = "hoi"
                }
            );

            CrossWalkthrough.Current.Theme = theme;
        }
    }
}
