using System;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Extensions;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class VestaPage : DefaultPage, IVestaPage
    {
        protected override int FragmentLayoutId => Resource.Layout.theme_vesta_page;
        protected override int TitleResourceId => Resource.Id.theme_vesta_title;
        protected override int ImageResourceId => Resource.Id.theme_vesta_image;
        protected override int DescriptionResourceId => Resource.Id.theme_vesta_description;
        protected int BackgroundImageResourceID => Resource.Id.theme_vesta_background_image;

        public ImageControl BackgroundImage { get; set; }
        public bool FadeBackgroundToBlack { get; set; }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            var backGroundImage = view.FindViewById<ImageView>(BackgroundImageResourceID);
            backGroundImage.SetControl(BackgroundImage);

            if (FadeBackgroundToBlack)
            {
                var backGround = view.FindViewById<LinearLayout>(Resource.Id.theme_vesta_bottom_half_layout);
                backGround.SetBackgroundResource(Resource.Drawable.clear_to_dark_vertical_gradient);
            }
            return view;
        }
    }
}