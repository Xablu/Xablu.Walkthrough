using System.Collections.Generic;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Abstractions.Themes;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public class Theme<TPage, TContainer> : ITheme<TPage, TContainer>
        where TPage : IPage where TContainer : IContainer, new()
    {
        private List<TPage> pages = new List<TPage>();

        public List<TPage> Pages
        {
            get => pages;
            set => pages = value;
        }

        private TContainer container = new TContainer();

        public TContainer Container
        {
            get => container;
            set => container = value;
        }
    }
}