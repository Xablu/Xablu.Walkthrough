using System;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Extensions;
using static Android.Support.V4.View.ViewPager;
using System.Drawing;
using Splat;
using Plugin.Xablu.Walkthrough.Indicator;
using Plugin.Xablu.Walkthrough.Abstractions.Containers;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class ForestPrimesContainer : DefaultContainer, IForestPrimesContainer, IOnPageChangeListener
    {
        protected override int FragmentLayoutId => Resource.Layout.theme_forestprime_container;

        public TextView StartButton;
        public AppCompatImageButton NextButton;

        public bool IsCanceable { get; set; } = false;

        private ImageButtonControl nextButtonControl = new ImageButtonControl()
        {
            ClickAction = () => CrossWalkthrough.Current.Next()
        };

        public ImageButtonControl NextButtonControl
        {
            get => nextButtonControl;
            set => nextButtonControl = value;
        }

        private ButtonControl skipButtonControl = new ButtonControl()
        {
            Text = "SKIP",
            ClickAction = () => { CrossWalkthrough.Current.Close(); }
        };

        public ButtonControl SkipButtonControl
        {
            get => skipButtonControl;
            set => skipButtonControl = value;
        }

        private ButtonControl startButtonControl = new ButtonControl()
        {
            Text = "Next",
            ClickAction = () => { CrossWalkthrough.Current.Close(); }
        };

        public ButtonControl StartButtonControl
        {
            get => startButtonControl;
            set => startButtonControl = value;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            ViewPager.AddOnPageChangeListener(this);

            var bottomNavigation = view.FindViewById<LinearLayout>(Resource.Id.theme_forestprime_bottomlayout);

            var skipButton = view.FindViewById<Button>(Resource.Id.btnSkip);
            skipButton.SetControl(SkipButtonControl);
            skipButton.Click += (sender, e) => skipButtonControl?.ClickAction();

            NextButton = view.FindViewById<AppCompatImageButton>(Resource.Id.btnNext);
            NextButton.SetControl(NextButtonControl);

            StartButton = view.FindViewById<TextView>(Resource.Id.btnStart);
            StartButton.SetControl(StartButtonControl);
            StartButton.Click += (sender, e) => startButtonControl.ClickAction();

            Cancelable = IsCanceable;

            return view;
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
            if (position != ViewPager.Adapter.Count - 1)
            {
                if (ViewPager.Adapter.Count - 2 == position)
                {
                    FadeOutFadeInOnScroll(positionOffset, StartButton, NextButton);
                }
            }
        }

        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageSelected(int position)
        {
            if (position + 1 == ViewPager.Adapter.Count)
            {
                StartButton.Visibility = ViewStates.Visible;
                StartButton.Alpha = 1;

                NextButton.Visibility = ViewStates.Gone;
            }
            else
            {
                NextButton.Visibility = ViewStates.Visible;
            }
        }

        private void FadeOutFadeInOnScroll(float positionOffset, View firstControl, View secondControl)
        {
            if (positionOffset >= 0.5)
            {
                firstControl.Visibility = ViewStates.Visible;
                float startAplha = (positionOffset - 0.5f) * 2; // fadein
                firstControl.Alpha = startAplha;
                secondControl.Alpha = 0;
            }
            else
            {
                var alpha = 1 - (positionOffset * 2); // fadeout
                secondControl.Alpha = alpha;
                firstControl.Alpha = 0;
                firstControl.Visibility = ViewStates.Gone;
            }
        }
    }
}