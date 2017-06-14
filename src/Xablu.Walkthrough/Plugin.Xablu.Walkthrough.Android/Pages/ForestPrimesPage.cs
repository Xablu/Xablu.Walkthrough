using System;
using System.Drawing;
using Android.OS;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using Walker;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class ForestPrimesPage : WalkerFragment
    {
        public Color BackgroundColor = Color.PaleGreen;

        public TextControl TitleControl;

        public ImageControl CenterImage;

        public TextControl DescriptionControl;

        protected override int PagePosition => 0;

        private WalkerLayout _walkerLayout;
        protected override WalkerLayout WalkerLayout => _walkerLayout;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _walkerLayout = (WalkerLayout)inflater.Inflate(Resource.Layout.theme_forestprime_page, container, false);

            //title
            var txtTitle = WalkerLayout.FindViewById<TextView>(Resource.Id.theme_forestprime_title);
            txtTitle.SetControl(TitleControl);

            //image
            var image = WalkerLayout.FindViewById<ImageView>(Resource.Id.theme_forestprime_image);
            image.SetControl(CenterImage);

            //description
            var txtDesc = WalkerLayout.FindViewById<TextView>(Resource.Id.theme_forestprime_description);
            txtDesc.SetControl(DescriptionControl);

            return WalkerLayout;
        }
    }
}