using Android.OS;
using Android.Views;
using Plugin.Xablu.Walkthrough.Pages;
using Splat;
using Walker;

namespace Plugin.Xablu.Walkthrough.Fragments
{
    public class ForestPrimeFragment : WalkerFragment
    {
        protected override int PagePosition => 0;

        private WalkerLayout _walkerLayout;
        protected override WalkerLayout WalkerLayout => _walkerLayout;

        public ForestPrimesPage Page { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_forestprime_page, container, false);

            //Title
            //var txtTitle = view.FindViewById<TextView>(Resource.Id.theme_forestprime_title);
            //txtTitle.Text = Page.Title.Text;
            //txtTitle.TextSize = Page.Title.TextSize;
            //txtTitle.SetTextColor(Page.Title.TextColor.ToNative());

            //  view.SetBackgroundColor(Page.BackgroundColor.ToNative());

            return view;
        }
    }
}
