using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Plugin.Xablu.Walkthrough.Indicator;
using System.Drawing;
using Splat;
using Android.Graphics.Drawables.Shapes;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class AndroidViewExtensions
    {
        public static void SetControl(this TextView textview, TextControl control)
        {
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

        public static void SetControl(this AppCompatImageButton imageView, ImageButtonControl control)
        {
            if (control.Image != null)
                imageView.SetImageDrawable(GetImage(control.Image));
            if (control.ClickAction != null)
                imageView.Click += (sender, e) => control.ClickAction();
        }

        public static void SetControl(this ImageView imageView, ImageControl control)
        {
            if (control.Image != null)
                imageView.SetImageDrawable(GetImage(control.Image));
        }

        public static void SetControl(this CircleIndicator circleIndicator, PageControl pageControl)
        {
            if (pageControl != null)
            {
                circleIndicator.SelectedDrawable = createRoundedIndicator(pageControl.SelectedPageColor);
                circleIndicator.UnselectedDrawable = createRoundedIndicator(pageControl.UnSelectedPageColor);
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
