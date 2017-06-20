using System.Drawing;
using Android.OS;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Extensions;
using Walker;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public class ForestPrimesPage : WalkerFragment, IForestPrimesPage
    {
        public Color BackgroundColor { get; set; } = Color.White;

        public TextControl TitleControl { get; set; }

        public ImageControl CenterImageControl { get; set; }

        public TextControl DescriptionControl { get; set; }

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
            image.SetControl(CenterImageControl);

            //description
            var txtDesc = WalkerLayout.FindViewById<TextView>(Resource.Id.theme_forestprime_description);
            txtDesc.SetControl(DescriptionControl);

            return WalkerLayout;
        }
    }
}