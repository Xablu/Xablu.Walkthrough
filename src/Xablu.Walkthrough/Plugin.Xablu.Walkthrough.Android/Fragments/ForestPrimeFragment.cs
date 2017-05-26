using Android.OS;
using Android.Views;
using Android.Widget;
using Walker;

namespace Plugin.Xablu.Walkthrough.Fragments
{
    public class ForestPrimeFragment : WalkerFragment
    {
        protected override int PagePosition => 0;

        private WalkerLayout _walkerLayout;
        protected override WalkerLayout WalkerLayout => _walkerLayout;

        public string Title { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_forestprime, container, false);
            var txtTitle = view.FindViewById<TextView>(Resource.Id.title);
            txtTitle.Text = Title;

            return view;
        }
    }
}
