using Android.OS;
using Android.Views;
using Walker;

namespace WalkthroughSample.Droid.Fragments
{
    public class FirstPageFragment : WalkerFragment
    {
        protected override int PagePosition => 0;

        private WalkerLayout _walkerLayout;
        protected override WalkerLayout WalkerLayout => _walkerLayout;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.FirstFragment, container, false);
        }
    }
}
