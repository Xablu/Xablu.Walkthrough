using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class VestaPage : DefaultPage, IVestaPage
    {
        public ImageControl ImageControl { get; set; }
        public TextControl TitleControl { get; set; }
        public TextControl DescriptionControl { get; set; }
    }
}