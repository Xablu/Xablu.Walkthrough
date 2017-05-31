using System.Drawing;
using System.Threading.Tasks;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Pages;
using Plugin.Xablu.Walkthrough.Themes;
using Splat;

namespace WalkthroughSample
{
    public class MyClass
    {
        public MyClass()
        {

        }

        public async Task SetTheme()
        {
            var theme = new ForestPrimes();

            theme.Pages.Add(
                new ForestPrimesPage()
                {
                    BackgroundColor = Color.FromArgb(239, 239, 239),
                    TitleControl = new TextControl()
                    {
                        Text = "Get count information",
                        TextSize = 24,
                        TextColor = Color.FromArgb(255, 0, 43)
                    },
                    CenterImage = new ImageControl()
                    {
                        Image = "ic_walkthrough_folder"
                    },
                    DescriptionControl = new TextControl()
                    {
                        Text = "Keep track of receipts by capturing and uploading them instantly wherever you are",
                        TextSize = 16
                    }
                }
            );

            theme.Pages.Add(

                new ForestPrimesPage()
                {
                    BackgroundColor = Color.FromArgb(239, 239, 239),
                    TitleControl = new TextControl()
                    {
                        Text = "Answer onsite queries",
                        TextSize = 24,
                        TextColor = Color.FromArgb(255, 0, 43)
                    },
                    CenterImage = new ImageControl()
                    {
                        Image = "ic_walkthrough_questions"
                    },
                    DescriptionControl = new TextControl()
                    {
                        Text = "Effortlessly approve or sign documents and carry out to-do’s",
                        TextSize = 16
                    }
                }
            );

            theme.Pages.Add(
                new ForestPrimesPage()
                {
                    BackgroundColor = Color.FromArgb(239, 239, 239),
                    TitleControl = new TextControl()
                    {
                        Text = "Count inventory",
                        TextSize = 24,
                        TextColor = Color.FromArgb(255, 0, 43)
                    },
                    CenterImage = new ImageControl()
                    {
                        Image = "ic_walkthrough_count"
                    },
                    DescriptionControl = new TextControl()
                    {
                        Text = "Find all the information needed to get in touch with your assigned BDO advisors",
                        TextSize = 16
                    },
                    FinishedButton = new ButtonControl()
                    {
                        Text = "START",
                        BackgroundColor = Color.FromArgb(0, 237, 26, 59),
                        TextSize = 16,
                        TextColor = Color.FromArgb(255, 0, 43),
                        ClickAction = () =>
                        {
                            var debug = new object();
                            var x = debug;
                        }
                    }
                }
            );

            CrossWalkthrough.Current.Theme = theme;
            CrossWalkthrough.Current.Show();
        }
    }
}
