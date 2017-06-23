using Android.OS;
using Android.Views;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Indicator;
using Plugin.Xablu.Walkthrough.Extensions;
using Android.Widget;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class PantheonContainer : DefaultContainer, IPantheonContainer
    {
        protected override int FragmentLayoutId => Resource.Layout.theme_pantheon_container;
        protected virtual int StartButtonResourceId => Resource.Id.theme_pantheon_get_started;

        public ButtonControl GetStartedButtonControl { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var startButton = view.FindViewById<Button>(StartButtonResourceId);
            startButton.SetControl(GetStartedButtonControl);

            return view;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            CircleIndicator.SetViewPager(ViewPager);
        }
    }
}