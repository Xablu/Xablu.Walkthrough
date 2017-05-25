using System;
using System.Collections.Generic;

namespace Plugin.Xablu.Walkthrough.Themes
{
    public abstract class BaseTheme<T> : ITheme where T : IPage
    {
        public abstract IEnumerable<T> Pages { get; set; }

        public BaseTheme() { }
    }
}
