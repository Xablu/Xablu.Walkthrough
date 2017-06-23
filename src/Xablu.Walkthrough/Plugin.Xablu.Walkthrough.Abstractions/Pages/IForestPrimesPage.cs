using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Pages
{
    public interface IForestPrimesPage
    {
        ImageControl ImageControl { get; set; }
        TextControl TitleControl { get; set; }
        TextControl DescriptionControl { get; set; }
    }
}
