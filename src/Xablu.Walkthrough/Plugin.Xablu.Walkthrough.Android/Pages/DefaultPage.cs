using System.Drawing;
using Android.OS;
using Android.Views;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Abstractions.Pages;
using Plugin.Xablu.Walkthrough.Extensions;
using Walker;

namespace Plugin.Xablu.Walkthrough.Pages
{
    public abstract class DefaultPage : WalkerFragment, IDefaultPage
    {
        private WalkerLayout _walkerLayout;

        protected override int PagePosition => 0;
        protected abstract int FragmentLayoutId { get; }
        protected abstract int TitleResourceId { get; }
        protected abstract int ImageResourceId { get; }
        protected abstract int DescriptionResourceId { get; }

		public virtual Color BackgroundColor { get; set; } = Color.White;
		public virtual TextControl TitleControl { get; set; }
		public virtual ImageControl ImageControl { get; set; }
		public virtual TextControl DescriptionControl { get; set; }
		
		protected override WalkerLayout WalkerLayout => _walkerLayout;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			_walkerLayout = (WalkerLayout)inflater.Inflate(FragmentLayoutId, container, false);

			//title
			var txtTitle = WalkerLayout.FindViewById<TextView>(TitleResourceId);
			txtTitle.SetControl(TitleControl);

			//image
			var image = WalkerLayout.FindViewById<ImageView>(ImageResourceId);
			image.SetControl(ImageControl);

			//description
			var txtDesc = WalkerLayout.FindViewById<TextView>(DescriptionResourceId);
			txtDesc.SetControl(DescriptionControl);

			return WalkerLayout;
		}
    }
}
