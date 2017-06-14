using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Splat;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class AndroidViewExtensions
    {
        public static void SetControl<T>(this TextView textview, T control) where T : TextControl
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

        public static void SetControl<T>(this AppCompatImageButton imageView, T control) where T : ImageButtonControl
        {
            if (control.Image != null)
                imageView.SetImageDrawable(GetImage(control.Image));
            if (control.ClickAction != null)
                imageView.Click += (sender, e) => control.ClickAction();
        }

        public static void SetControl<T>(this ImageView imageView, T control) where T : ImageControl
        {
            if (control.Image != null)
                imageView.SetImageDrawable(GetImage(control.Image));
        }

        private static Drawable GetImage(string resource)
        {
            return BitmapLoader.Current.LoadFromResource(resource, null, null).Result.ToNative();
        }
    }
}
