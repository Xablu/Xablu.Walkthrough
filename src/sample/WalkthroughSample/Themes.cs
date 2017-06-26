using System;
using System.Collections.Generic;
using System.Drawing;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Pages;
using Plugin.Xablu.Walkthrough.Themes;

namespace WalkthroughSample
{
    public class Themes
    {
        public List<VestaPage> VestaPages = new List<VestaPage>()
        {
            new VestaPage
            {
                TitleControl = new TextControl()
                {
                    Text = "Title",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                ImageControl = new ImageControl()
                {
                    Image = "iPhone"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    TextSize = 16
                }
            },
            new VestaPage
            {
                BackgroundColor = Color.FromArgb(239, 239, 239),
                TitleControl = new TextControl()
                {
                    Text = "Title",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                ImageControl = new ImageControl()
                {
                    Image = "iPhone"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    TextSize = 16
                }
            },
            new VestaPage
            {
                BackgroundColor = Color.FromArgb(180, 180, 180),
                TitleControl = new TextControl()
                {
                    Text = "Change backgroundcolor",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                ImageControl = new ImageControl()
                {
                    Image = "iPhone"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. rnare lorem. ",
                    TextSize = 16
                }
            }
        };

        public List<ForestPrimesPage> ForestPages = new List<ForestPrimesPage>()
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

        public void ForestContainerForestPage()
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
            theme.Pages = ForestPages;


            //    CrossWalkthrough.Current.Page = 2;

            CrossWalkthrough.Current.Setup(theme);
            CrossWalkthrough.Current.Show();
        }

        public void PantheonContainerForestPage()
        {
            var theme = new Theme<ForestPrimesPage, PantheonContainer>();
            theme.Container = new PantheonContainer()
            {
                GetStartedButtonControl = new ButtonControl()
                {
                    Text = "GET STARTED",
                    TextColor = Color.White,
                    TextStyle = 1,
                    BackgroundColor = Color.LimeGreen,
                    ClickAction = () => CrossWalkthrough.Current.Close()
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

        public void VestaContainerVestaPage()
        {
            var theme = new Theme<VestaPage, VestaContainer>();
            theme.Container = new VestaContainer()
            {
                GetStartedButtonControl = new ButtonControl()
                {
                    Text = "GET STARTED",
                    TextColor = Color.White,
                    TextStyle = 1,
                    BackgroundColor = Color.LimeGreen,
                    ClickAction = () => CrossWalkthrough.Current.Close()
                },
                CirclePageControl = new PageControl()
                {
                    SelectedPageColor = Color.FromArgb(237, 26, 59),
                    UnSelectedPageColor = Color.FromArgb(236, 104, 128)
                }
            };

            theme.Pages = VestaPages;

            CrossWalkthrough.Current.Setup(theme);
            CrossWalkthrough.Current.Show();
        }
    }
}