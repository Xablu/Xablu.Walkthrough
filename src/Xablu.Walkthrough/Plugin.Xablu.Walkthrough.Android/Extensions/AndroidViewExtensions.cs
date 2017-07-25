using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Indicator;
using System.Drawing;
using Splat;
using Android.Graphics.Drawables.Shapes;
using Android.Views;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class AndroidViewExtensions
    {
        public static void SetControl(this View view, BaseControl control)
        {
            view.Visibility = control.Hidden ? ViewStates.Gone : ViewStates.Visible;
        }

        public static void SetControl(this TextView textview, TextControl control)
        {
            if (control == null)
                return;
            
            textview.SetControl(control as BaseControl);
            textview.Text = control.Text;
            textview.TextSize = control.TextSize;
            textview.SetTextColor(control.TextColor.ToNative());		
            
            switch (control.TextStyle)
            {
                case 1:
                    textview.SetTypeface(textview.Typeface, Android.Graphics.TypefaceStyle.Bold);
                    break;
                case 2:
                    textview.SetTypeface(textview.Typeface, Android.Graphics.TypefaceStyle.Italic);
                    break;
            }
        }

        public static void SetControl(this Button button, ButtonControl control)
        {
			if (control == null)
				return;
            
            SetControl(button as TextView, control);

			if (control.ClickAction != null)
				button.Click += (sender, e) => control.ClickAction();
            
            button.SetBackgroundColor(control.BackgroundColor.ToNative());
        }

        public static void SetControl(this AppCompatImageButton imageView, ImageButtonControl control)
        {
			if (control == null)
				return;
            
            imageView.SetControl(control as BaseControl);
            if (control.Image != null)
                imageView.SetImageDrawable(GetImage(control.Image));
            if (control.ClickAction != null)
                imageView.Click += (sender, e) => control.ClickAction();
        }

        public static void SetControl(this ImageView imageView, ImageControl control)
        {
			if (control == null)
				return;
            
            imageView.SetControl(control as BaseControl);
            if (control.Image != null)
                imageView.SetImageDrawable(GetImage(control.Image));
        }

        public static void SetControl(this CircleIndicator circleIndicator, PageControl control)
        {
			if (control == null)
				return;
            
            circleIndicator.SetControl(control as BaseControl);
            if (control != null)
            {
                circleIndicator.SelectedDrawable = createRoundedIndicator(control.SelectedPageColor);
                circleIndicator.UnselectedDrawable = createRoundedIndicator(control.UnSelectedPageColor);
            }
        }

        private static ShapeDrawable createRoundedIndicator(Color color)
        {
            var drawable = new ShapeDrawable(new OvalShape());
            drawable.Paint.Color = color.ToNative();
            return drawable;
        }

        private static Drawable GetImage(string resource)
        {
            return BitmapLoader.Current.LoadFromResource(resource, null, null).Result.ToNative();
        }
    }
}