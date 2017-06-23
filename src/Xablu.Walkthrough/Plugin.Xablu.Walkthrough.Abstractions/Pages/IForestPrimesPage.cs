using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Pages
{
    public interface IForestPrimesPage
    {
        public ImageControl ImageControl { get; set; }
        public TextControl TitleControl { get; set; }
        public TextControl DescriptionControl { get; set; }
    }
}
