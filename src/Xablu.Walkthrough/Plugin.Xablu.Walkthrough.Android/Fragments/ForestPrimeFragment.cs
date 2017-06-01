using Android.OS;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Pages;
using Splat;
using Walker;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Extensions;

namespace Plugin.Xablu.Walkthrough.Fragments
{
    public class ForestPrimeFragment : WalkerFragment
    {
        protected override int PagePosition => 0;

        private WalkerLayout _walkerLayout;
        protected override WalkerLayout WalkerLayout => _walkerLayout;

        public ForestPrimesPage Page { get; set; }
        public ForestPrimesContainer Container { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _walkerLayout = (WalkerLayout)inflater.Inflate(Resource.Layout.theme_forestprime_page, container, false);

            WalkerLayout.SetBackgroundColor(Page.BackgroundColor.ToNative());

            //title
            var txtTitle = WalkerLayout.FindViewById<TextView>(Resource.Id.theme_forestprime_title);
            txtTitle.SetValues(Page.TitleControl);

            //image
            var image = WalkerLayout.FindViewById<ImageView>(Resource.Id.theme_forestprime_image);
            image.SetValues(Page.CenterImage);

            //description
            var txtDesc = WalkerLayout.FindViewById<TextView>(Resource.Id.theme_forestprime_description);
            txtDesc.SetValues(Page.DescriptionControl);

            if (Page.FinishedButton != null)
                Container.SetFinalizeTextView(Page.FinishedButton);

            return WalkerLayout;
        }
    }
}
