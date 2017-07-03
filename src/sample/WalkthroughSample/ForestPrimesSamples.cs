using System.Drawing;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Themes;
using System.Collections.Generic;
using Plugin.Xablu.Walkthrough.Pages;

namespace WalkthroughSample
{
    public static class ForestPrimesSamples
    {
        public static List<ForestPrimesPage> ForestPages = new List<ForestPrimesPage>()
        {
            new ForestPrimesPage()
            {
                TitleControl = new TextControl()
                {
                    Text = "Welcome!",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                ImageControl = new ImageControl()
                {
                    Image = "xamarin"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "This is the XABLU.Walkthrough. It's an easy way to create and manage walkthroughs cross platform!",
                    TextSize = 16,
                    TextStyle = 1
                }
            },
            new ForestPrimesPage()
            {
                BackgroundColor = Color.FromArgb(240, 240, 240),
                TitleControl = new TextControl()
                {
                    Text = "Lots of options!",
                    TextSize = 28,
                    TextColor = Color.FromArgb(50, 50, 50)
                },
                ImageControl = new ImageControl()
                {
                    Image = "androidandios"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Change the backgroundcolor, textsize, whatever you want from 1 point in your code!",
                    TextSize = 18
                }
            },
            new ForestPrimesPage()
            {
                BackgroundColor = Color.FromArgb(239, 239, 239),
                TitleControl = new TextControl()
                {
                    Text = "Take advantage now!",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43),
                    TextStyle = 1
                },
                ImageControl = new ImageControl()
                {
                    Image = "xablu"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Don't build it yourself, use the XABLU plugin! It's easy to extend and implement!",
                    TextSize = 16
                }
            }
        };

        public static List<OvuPage> OvuPages = new List<OvuPage>()
        {
            new OvuPage()
            {
                TitleControl = new TextControl()
                {
                    Text = "Welcome! Welcome! Welcome! Welcome!",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                ImageControl = new ImageControl()
                {
                    Image = "xamarin"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "This is the XABLU.Walkthrough. It's an easy way to create and manage walkthroughs cross platform!",
                    TextSize = 16,
                    TextStyle = 1
                }
            },
            new OvuPage()
            {
                BackgroundColor = Color.FromArgb(240, 240, 240),
                TitleControl = new TextControl()
                {
                    Text = "Lots of options!",
                    TextSize = 28,
                    TextColor = Color.FromArgb(50, 50, 50)
                },
                ImageControl = new ImageControl()
                {
                    Image = "androidandios"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Change the backgroundcolor, textsize, whatever you want from 1 point in your code!",
                    TextSize = 18
                }
            },
            new OvuPage()
            {
                BackgroundColor = Color.FromArgb(239, 239, 239),
                TitleControl = new TextControl()
                {
                    Text = "Take advantage now!",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43),
                    TextStyle = 1
                },
                ImageControl = new ImageControl()
                {
                    Image = "xablu"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Don't build it yourself, use the XABLU plugin! It's easy to extend and implement!",
                    TextSize = 16
                }
            }
        };

        public static void ShowForestContainerOvuPage()
        {
            var theme = new Theme<OvuPage, ForestPrimesContainer>();
            theme.Container = new ForestPrimesContainer()
            {
                StartButtonControl = new ButtonControl()
                {
                    Text = "START",
                    BackgroundColor = Color.FromArgb(0, 237, 26, 59),
                    TextSize = 16,
                    TextColor = Color.FromArgb(255, 0, 43),
                    ClickAction = () => { CrossWalkthrough.Current.Close(); },
                    TextStyle = 1
                },
                NextButtonControl = new ImageButtonControl()
                {
                    Image = "ArrowRight",
                    ClickAction = () => CrossWalkthrough.Current.Next()
                },
                CirclePageControl = new PageControl()
                {
                    SelectedPageColor = Color.FromArgb(237, 26, 59),
                    UnSelectedPageColor = Color.FromArgb(236, 104, 128)
                }
            };
            // CrossWalkthrough.Current.Page = 2;

            theme.Pages = OvuPages;

            CrossWalkthrough.Current.Setup(theme);
            CrossWalkthrough.Current.Show();
        }

        public static void ShowForestContainerForestPage()
        {
            var theme = new Theme<ForestPrimesPage, ForestPrimesContainer>();
            theme.Container = new ForestPrimesContainer()
            {
                StartButtonControl = new ButtonControl()
                {
                    Text = "START",
                    BackgroundColor = Color.FromArgb(0, 237, 26, 59),
                    TextSize = 16,
                    TextColor = Color.FromArgb(255, 0, 43),
                    ClickAction = () => { CrossWalkthrough.Current.Close(); },
                    TextStyle = 1
                },
                NextButtonControl = new ImageButtonControl()
                {
                    Image = "ArrowRight",
                    ClickAction = () => CrossWalkthrough.Current.Next()
                },
                CirclePageControl = new PageControl()
                {
                    SelectedPageColor = Color.FromArgb(237, 26, 59),
                    UnSelectedPageColor = Color.FromArgb(236, 104, 128)
                }
            };
            // CrossWalkthrough.Current.Page = 2;

            theme.Pages = ForestPages;

            CrossWalkthrough.Current.Setup(theme);
            CrossWalkthrough.Current.Show();
        }
    }
}
