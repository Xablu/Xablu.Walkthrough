using Plugin.Xablu.Walkthrough.Extensions;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public partial class ForestPrimesPage : DefaultPage
    {
        public ForestPrimesPage() : base("ForestPrimesPage", null)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title.SetControl(TitleControl);

            await CenterImage.SetControl(ImageControl);

            Description.SetControl(DescriptionControl);
        }
    }
}

