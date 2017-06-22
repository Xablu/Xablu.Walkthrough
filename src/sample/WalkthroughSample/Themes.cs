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
        public List<ForestPrimesPage> ForestPages = new List<ForestPrimesPage>()
        {
            new ForestPrimesPage()
            {
                TitleControl = new TextControl()
                {
                    Text = "Get count information",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                CenterImageControl = new ImageControl()
                {
                    Image = "iPhone"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Keep track of receipts by capturing and uploading them instantly wherever you are",
                    TextSize = 16
                }
            },
            new ForestPrimesPage()
            {
                BackgroundColor = Color.FromArgb(239, 239, 239),
                TitleControl = new TextControl()
                {
                    Text = "Answer onsite queries",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                CenterImageControl = new ImageControl()
                {
                    Image = "iPhone"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Effortlessly approve or sign documents and carry out to-do’s",
                    TextSize = 16
                }
            },
            new ForestPrimesPage()
            {
                BackgroundColor = Color.FromArgb(239, 239, 239),
                TitleControl = new TextControl()
                {
                    Text = "Count inventory",
                    TextSize = 24,
                    TextColor = Color.FromArgb(255, 0, 43)
                },
                CenterImageControl = new ImageControl()
                {
                    Image = "iPhone"
                },
                DescriptionControl = new TextControl()
                {
                    Text = "Find all the information needed to get in touch with your assigned BDO advisors",
                    TextSize = 16
                }
            }
        };

        public void ForestContainerForestPage()
        {
            var theme = new Theme<ForestPrimesPage, ForestPrimesContainer>();
            theme.Container = new ForestPrimesContainer()
            {
                BackgroundColor = Color.LightGray,
                StartButtonControl = new ButtonControl()
                {
                    Text = "START",
                    BackgroundColor = Color.FromArgb(0, 237, 26, 59),
                    TextSize = 16,
                    TextColor = Color.FromArgb(255, 0, 43),
                    ClickAction = () =>
                    {
                        CrossWalkthrough.Current.Close();
                    },
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


            CrossWalkthrough.Current.Page = 2;

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
    }
}
