using System;
using Android.OS;
using Android.Support.Design.Widget;
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
    public class ForestPrimesContainer : BaseContainer, IForestPrimesContainer, IOnPageChangeListener
    {
        public TextView StartButton;
        public AppCompatImageButton NextButton;

        public Color BackgroundColor { get; set; } = Color.White;

        public bool IsCanceable { get; set; } = false;

        private ImageButtonControl nextButtonControl = new ImageButtonControl()
        {
            ClickAction = () =>
            {
                CrossWalkthrough.Current.Next();
            }
        };

        public ImageButtonControl NextButtonControl
        {
            get => nextButtonControl;
            set => nextButtonControl = value;
        }

        private ButtonControl skipButtonControl = new ButtonControl()
        {
            Text = "SKIP",
            ClickAction = () =>
            {
                CrossWalkthrough.Current.Close();
            }
        };

        public ButtonControl SkipButtonControl
        {
            get => skipButtonControl;
            set => skipButtonControl = value;
        }

        private ButtonControl startButtonControl = new ButtonControl()
        {
            Text = "Next",
            ClickAction = () =>
            {
                CrossWalkthrough.Current.Close();
            }
        };

        public ButtonControl StartButtonControl
        {
            get => startButtonControl;
            set => startButtonControl = value;
        }

        public PageControl CirclePageControl { get; set; }

        private CircleIndicator circleIndicator;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_forestprime_container, container, false);

            view.SetBackgroundColor(BackgroundColor.ToNative());

            ViewPager = (ViewPager)view.FindViewById(Resource.Id.view_pager);
            ViewPager.AddOnPageChangeListener(this);

            var bottomNavigation = view.FindViewById<LinearLayout>(Resource.Id.theme_forestprime_bottomlayout);

            circleIndicator = view.FindViewById<CircleIndicator>(Resource.Id.indicator);
            circleIndicator.SetControl(CirclePageControl);
            circleIndicator.SetViewPager(ViewPager);

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

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            circleIndicator.SetViewPager(ViewPager);
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
            if (position != ViewPager.Adapter.Count - 1)
            {
                if (ViewPager.Adapter.Count - 2 == position)
                {
                    fadeOutFadeInOnScroll(positionOffset, StartButton, NextButton);
                }
            }
        }

        public void OnPageScrollStateChanged(int state)
        {

        }

        public void OnPageSelected(int position)
        {

        }

        private void fadeOutFadeInOnScroll(float positionOffset, View firstControl, View secondControl)
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
