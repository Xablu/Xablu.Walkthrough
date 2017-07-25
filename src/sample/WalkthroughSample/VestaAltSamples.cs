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
    public class VestaAltSamples
    {
		public static List<VestaPage> VestaPages = new List<VestaPage>()
		{
			new VestaPage
			{
                FadeBackgroundToBlack = true,
				TitleControl = new TextControl()
				{
					Text = "Title",
					TextSize = 24,
                    TextColor = Color.White
				},
				ImageControl = new ImageControl()
				{
                    Hidden = true
				},
				DescriptionControl = new TextControl()
				{
					Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
					TextSize = 16,
					TextColor = Color.White
				},
                BackgroundImage = new ImageControl()
                {
                    Image = "xamarin"
                }
			},
			new VestaPage
			{
                FadeBackgroundToBlack = true,
				TitleControl = new TextControl()
				{
					Text = "Title",
					TextSize = 24,
					TextColor = Color.White
				},
				ImageControl = new ImageControl()
				{
                    Hidden = true					
				},
				DescriptionControl = new TextControl()
				{
					Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
					TextSize = 16,
					TextColor = Color.White
				},
				BackgroundImage = new ImageControl()
				{
                    Image = "androidandios"
				}
			},
			new VestaPage
            {
                FadeBackgroundToBlack = true,
				TitleControl = new TextControl()
				{
					Text = "Title",
					TextSize = 24,
					TextColor = Color.White
				},
				ImageControl = new ImageControl()
				{
                    Hidden = true
				},
				DescriptionControl = new TextControl()
				{
					Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. rnare lorem. ",
					TextSize = 16,
					TextColor = Color.White
				},
				BackgroundImage = new ImageControl()
				{
					Image = "xablu"
				}
			}
		};

		public static void ShowVestaAltContainerVestaPage()
		{
			var theme = new Theme<VestaPage, VestaContainer>();
            theme.Container = new VestaContainer()
            {
                GetStartedButtonControl = new ButtonControl()
                {
                    Hidden = true
                },
                CirclePageControl = new PageControl()
                {
                    SelectedPageColor = Color.White,
                    UnSelectedPageColor = Color.FromArgb(236, 104, 128)
                },
                NextButtonControl = new ButtonControl()
                {
                    Text = "Next",
					ClickAction = () => CrossWalkthrough.Current.Next(),
					TextColor = Color.White
                },
                LastPageNextButtonControl = new ButtonControl()
                {
                    Text = "Start",
					ClickAction = () => CrossWalkthrough.Current.Close(),
					TextColor = Color.White
                },
                PreviousButtonControl = new ButtonControl()
                {
                    Text = "Previous",
					ClickAction = () => CrossWalkthrough.Current.Previous(),
					TextColor = Color.White
                },
                FirstPagePreviousButtonControl = new ButtonControl()
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
