using Android.OS;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Pages;
using Splat;
using Walker;
using Plugin.Xablu.Walkthrough.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Fragments
{
    public class ForestPrimeFragment : WalkerFragment
    {
        protected override int PagePosition => 0;

        private WalkerLayout _walkerLayout;
        protected override WalkerLayout WalkerLayout => _walkerLayout;

        public ForestPrimesPage Page { get; set; }
        public ForestPrimesContainer Container { get; set; }
        private Button finishedButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.theme_forestprime_page, container, false);

            view.SetBackgroundColor(Page.BackgroundColor.ToNative());

            //title
            var txtTitle = view.FindViewById<TextView>(Resource.Id.theme_forestprime_title);
            BindTextView(txtTitle, Page.TitleControl);

            //image
            var image = view.FindViewById<ImageView>(Resource.Id.theme_forestprime_image);
            var splatImage = BitmapLoader.Current.LoadFromResource(Page.CenterImage.Image, null, null).Result;
            image.SetImageDrawable(splatImage.ToNative());

            //description
            var txtDesc = view.FindViewById<TextView>(Resource.Id.theme_forestprime_description);
            BindTextView(txtDesc, Page.DescriptionControl);

            if (Page.FinishedButton != null)
            {
                finishedButton = view.FindViewById<Button>(Resource.Id.theme_forestprime_gettingstarted);
                finishedButton.SetBackgroundColor(Page.FinishedButton.BackgroundColor.ToNative());
                finishedButton.SetTextColor(Page.FinishedButton.TextColor.ToNative());
                finishedButton.Text = Page.FinishedButton.Text;
                finishedButton.Click += (sender, e) =>
                {
                    Page.FinishedButton.ClickAction();
                };
            }

            return view;
        }

        public override bool UserVisibleHint
        {
            get
            {
                return base.UserVisibleHint;
            }
            set
            {
                base.UserVisibleHint = value;

                if (Page.FinishedButton != null && UserVisibleHint)
                {
                    Container.HideBottomNavigation = true;
                    finishedButton.Visibility = ViewStates.Visible;
                }
                else
                {
                    Container.HideBottomNavigation = false;
                }
            }
        }


        private void BindTextView(TextView textView, TextControl textControl)
        {
            textView.Text = textControl.Text;
            textView.TextSize = textControl.TextSize;
            textView.SetTextColor(textControl.TextColor.ToNative());
        }
    }
}
