using Plugin.Xablu.Walkthrough.Extensions;
using Splat;

namespace Plugin.Xablu.Walkthrough.Pages
{
	public partial class VestaPage : DefaultPage
	{
		public VestaPage() : base("VestaPage", null)
        {
		}

		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = BackgroundColor.ToNative();

			Title.SetControl(TitleControl);

			await Image.SetControl(ImageControl);

			Description.SetControl(DescriptionControl);
		}
	}
}

