using System;
namespace Plugin.Xablu.Walkthrough.Pages
{
    public class OvuPage : DefaultPage
    {
        protected override int FragmentLayoutId => Resource.Layout.theme_ovu_page;
        protected override int TitleResourceId => Resource.Id.theme_vesta_title;
        protected override int ImageResourceId => Resource.Id.theme_vesta_image;
        protected override int DescriptionResourceId => Resource.Id.theme_vesta_description;
    }
}
