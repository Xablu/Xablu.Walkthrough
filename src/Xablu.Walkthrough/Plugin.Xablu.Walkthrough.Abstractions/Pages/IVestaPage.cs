using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Pages
{
    public interface IVestaPage
    {
        ImageControl ImageControl { get; set; }
        TextControl TitleControl { get; set; }
        TextControl DescriptionControl { get; set; }
        ImageControl BackgroundImage { get; set; }
        bool FadeBackgroundToBlack { get; set; }
    }
}
