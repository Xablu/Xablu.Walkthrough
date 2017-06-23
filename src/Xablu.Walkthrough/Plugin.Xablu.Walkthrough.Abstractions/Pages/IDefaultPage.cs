using System.Drawing;

namespace Plugin.Xablu.Walkthrough.Abstractions.Pages
{
    public interface IDefaultPage : IPage
    {
        Color BackgroundColor { get; set; }
    }
}