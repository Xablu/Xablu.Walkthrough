using System;
using Plugin.Xablu.Walkthrough.Themes;

namespace Plugin.Xablu.Walkthrough.Abstractions
{
    /// <summary>
    /// Interface for Walkthrough
    /// </summary>
    public interface IWalkthrough
    {
        void Show();
        void Next();
        void Previous();
        void Close();
        ITheme Theme { get; set; }
    }
}
