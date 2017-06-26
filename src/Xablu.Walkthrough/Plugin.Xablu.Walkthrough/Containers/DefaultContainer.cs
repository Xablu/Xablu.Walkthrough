using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public abstract class DefaultContainer : IDefaultContainer
    {
        public virtual Color BackgroundColor { get; set; }
        public virtual PageControl CirclePageControl { get; set; }
    }
}