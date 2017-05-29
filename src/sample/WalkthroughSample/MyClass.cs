using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Pages;
using Plugin.Xablu.Walkthrough.Themes;

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
                    //BackgroundColor = System.Drawing.Color.FromArgb(33, 150, 243)
                }
            );

            //theme.Pages.Add(
            //    new ForestPrimesPage()
            //    {
            //        BackgroundColor = Color.FromArgb(133, 150, 243),
            //        Title = new TextControl()
            //        {
            //            Text = "DOEI!",
            //            TextSize = 20,
            //            TextColor = Color.FromArgb(155, 155, 255)
            //        }
            //    }
            //);

            CrossWalkthrough.Current.Theme = theme;
            CrossWalkthrough.Current.Show();
        }
    }
}
