using System;
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
            imageView.SetImageDrawable(GetImage(T.Image));
        }

        public static void SetControl<T>(this ImageView imageView, T control) where T : ImageControl
        {
            imageView.SetImageDrawable(GetImage(T.Image));
        }

        private static IBitmap GetImage(string resource)
        {
            return BitmapLoader.Current.LoadFromResource(resource, null, null).Result;
        }
    }
}
