using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using static Android.Support.V4.View.ViewPager;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class VestaContainer : PantheonContainer, IVestaContainer, IOnPageChangeListener
    {
        protected override int FragmentLayoutId => Resource.Layout.theme_vesta_container;
        protected override int StartButtonResourceId => Resource.Id.theme_vesta_get_started;
        protected virtual int PreviousButtonControlId => Resource.Id.theme_vesta_previous_text;
        protected virtual int NextButtonControlId => Resource.Id.theme_vesta_next_text;

        public ButtonControl PreviousButtonControl { get; set; }
        public ButtonControl NextButtonControl { get; set; }
        public ButtonControl FirstPagePreviousButtonControl { get; set; }
        public ButtonControl LastPageNextButtonControl { get; set; }

        private TextView previousButton;
        private TextView nextButton;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            ViewPager.AddOnPageChangeListener(this);

            previousButton = view.FindViewById<TextView>(PreviousButtonControlId);
            previousButton.SetControl(FirstPagePreviousButtonControl ?? PreviousButtonControl);
            previousButton.Click += (sender, e) => PreviousButtonClicked();

            nextButton = view.FindViewById<TextView>(NextButtonControlId);
            nextButton.SetControl(NextButtonControl ?? LastPageNextButtonControl);
            nextButton.Click += (sender, e) => NextButtonClicked();

            return view;
        }

        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
        }

        public void OnPageSelected(int position)
        {
            if (position == 0)
                previousButton.SetControl(FirstPagePreviousButtonControl ?? PreviousButtonControl);
            else
                previousButton.SetControl(PreviousButtonControl);

            if (position == ViewPager.Adapter.Count - 1)
                nextButton.SetControl(LastPageNextButtonControl ?? NextButtonControl);
            else
                nextButton.SetControl(NextButtonControl);
        }

        private void PreviousButtonClicked()
        {
            if (FirstPagePreviousButtonControl != null && ViewPager.CurrentItem == 0)
            {
                FirstPagePreviousButtonControl.ClickAction?.Invoke();
                return;
            }

            PreviousButtonControl?.ClickAction?.Invoke();
        }

        private void NextButtonClicked()
        {
            if (LastPageNextButtonControl != null && ViewPager.CurrentItem == ViewPager.Adapter.Count - 1)
            {
                LastPageNextButtonControl.ClickAction?.Invoke();
                return;
            }

            NextButtonControl?.ClickAction?.Invoke();
        }
    }
}