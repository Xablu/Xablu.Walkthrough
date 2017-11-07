# Xablu.Walkthrough
The Xablu Walkthrough helps you to easily add a walkthrough to your apps for both iOS and Android

### Setup & Usage
* Available on NuGet: https://www.nuget.org/packages/Xablu.Walkthrough/
* Install into each project that utilizes the Walkthrough

### Build Status: 
[![Build status](https://ci.appveyor.com/api/projects/status/mg1s91k0b02ccy7o?svg=true)](https://ci.appveyor.com/project/Xablu/xablu-walkthrough)
![GitHub tag](https://img.shields.io/github/tag/Xablu/Xablu.Walkthrough.svg)
[![NuGet](https://img.shields.io/nuget/v/Xablu.Walkthrough.svg?label=NuGet)](https://www.nuget.org/packages/Xablu.Walkthrough/)
[![MyGet](https://img.shields.io/myget/xabluhq/v/Xablu.Walkthrough.svg)](https://www.myget.org/F/Xablu.Walkthrough/api/v2)

# Containers & Pages

The plugin works with themes. Every theme must consist of a Container and a Page. Containers and Pages can be mixed and matched. The current available containers and pages are:

| ForestPrimes container and page| Pantheon container and ForestPage | Vesta container and page  |
| ------------------------------ |-----------------------------------| ------------------------- |
| ![ForestPrimes](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/fullforest.png) | ![Pantheon](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/pantheonforest.png) |![Vesta](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/fullvesta.png) |
| ![ForestPrimes](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/fullforest-android.png) | ![Pantheon](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/pantheonforest-android.png) | ![Vesta](https://github.com/Xablu/Xablu.Walkthrough/raw/master/resources/vesta-android.png) |

# Usage

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
                              TextSize = 24
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

