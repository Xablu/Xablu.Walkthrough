using System.Drawing;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Containers
{
    public interface IDefaultContainer : IContainer
    {
        Color BackgroundColor { get; set; }
        PageControl CirclePageControl { get; set; }
    }
}