using System;
using System.Collections.Generic;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Themes;
using System.Linq;


namespace WalkthroughSample
{
    public class MyClass
    {
        public MyClass()
        {
            var tour = CrossWalkthrough.Current.Init<ForestPrimes>();
            tour.Pages.ToList().AddRange(
                new List<ForestPrimesPage>
                {
                    new ForestPrimesPage()
                    {
                        Description = "test",
                        Title ="mooi"
                    },
                    new ForestPrimesPage()
                    {
                        Description = "wow",
                        Title = "wauw"
                    }
                }
            );
        }
    }
}
