﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Plugin.Xablu.Walkthrough;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Pages;
using Plugin.Xablu.Walkthrough.Themes;

namespace WalkthroughSample
{
    public static class VestaSamples
    {
        public static List<VestaPage> VestaPages = new List<VestaPage>()
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

        public static void ShowVestaContainerVestaPage()
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
                },
                NextButtonControl = new ButtonControl()
                {
                    Hidden = true
                },
                PreviousButtonControl = new ButtonControl()
				{
					Hidden = true
				}
            };

            theme.Pages = VestaPages;

            CrossWalkthrough.Current.Setup(theme);
            CrossWalkthrough.Current.Show();
        }
    }
}
