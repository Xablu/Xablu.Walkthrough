using Walker;
using Android.OS;
using Android.Views;

namespace WalkthroughSample.Droid.Fragments
{
    public class ThirdPageFragment : WalkerFragment
    {
        protected override int PagePosition => 0;

        private WalkerLayout _walkerLayout;
        protected override WalkerLayout WalkerLayout => _walkerLayout;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.ThirdFragment, container, false);
        }
    }
}
