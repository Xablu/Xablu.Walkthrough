# Xablu.Walkthrough
Having a walkthrough for Xamarin has never been so easy! Easily add a walkthrough to your apps for both iOS and Android. Manage the walkthrough from your shared code and don't worry about custom implementations!

## Setup & Usage
* Available on NuGet: https://www.nuget.org/packages/Xablu.Walkthrough/
* Install into each project that utilizes the WebApiClient

### Build Status: 
[![Build status](https://ci.appveyor.com/api/projects/status/5ey0sq4fn01t9o56?svg=true
)](https://ci.appveyor.com/project/Xablu/xablu-webapiclient)
![GitHub tag](https://img.shields.io/github/tag/Xablu/Xablu.WebApiClient.svg)
[![NuGet](https://img.shields.io/nuget/v/Xablu.WebApiClient.svg?label=NuGet)](https://www.nuget.org/packages/Xablu.WebApiClient/)
[![MyGet](https://img.shields.io/myget/xabluhq/v/Xablu.WebApiClient.svg)](https://www.myget.org/F/Xablu.WebApiClient/api/v2)

## Containers & Pages

The plugin works with themes. Every theme must consist of a Container and a Page. Containers and Pages can be mixed and matched. The current available containers and pages are:

| ForestPrimes container and page| Pantheon container and ForestPage | Vesta container and page  |
| ------------------------------ |-----------------------------------| ------------------------- |
| ![ForestPrimes](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/fullforest.png) | ![Pantheon](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/pantheonforest.png) |![Vesta](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/fullvesta.png) |
| ![ForestPrimes](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/fullforest-android.png) | ![Pantheon](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/pantheonforest-android.png) | ![Vesta](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/vesta-android.png) |

### Distinction between containers and pages
Pages are hosted inside the containers. They will consist of the PageControl, next and previous buttons etc. Pages are specific for that page. They consist of a image, title, description for example.

## Usage

After you have installed the nuget into every project simple create a new theme in your PCL library like so:

```c#
var theme = new Theme<ForestPrimesPage, ForestPrimesContainer>();
```

Now style your container the way you like, for example:

```c#
 theme.Container = new ForestPrimesContainer()
            {
                StartButtonControl = new ButtonControl()
                {
                    Text = "START",
                    BackgroundColor = Color.FromArgb(0, 237, 26, 59)
                },
                NextButtonControl = new ImageButtonControl()
                {
                    Image = "ArrowRight",
                    ClickAction = () => CrossWalkthrough.Current.Next()
                }
            };
```
Add as much pages to the theme as you like:
```c#
            theme.Pages.Add
                 (
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
                    );
```

Next call the setup method and show it:

```c#
CrossWalkthrough.Current.Setup(theme);
CrossWalkthrough.Current.Show();
```

## Make your own theme
Containers and pages can be mixed together in any way you like. This gives lots of customization opportunities to the plugin. If they current implementation doesn't suit your needs it's easy to add them. It basically consists of the following steps:

1. Add an interface for your container or page in the Abstractions project
2. Implement this interface on every platform(PCL,Android,iOS)
3. Create the layouts for the new container/page
3. Wire it up in the class that implements the interface ([iOS example](https://github.com/Xablu/Xablu.Walkthrough/blob/master/src/Xablu.Walkthrough/Plugin.Xablu.Walkthrough.iOS/Containers/VestaContainer.cs)
[Droid example](https://github.com/Xablu/Xablu.Walkthrough/blob/master/src/Xablu.Walkthrough/Plugin.Xablu.Walkthrough.Android/Containers/VestaContainer.cs))
