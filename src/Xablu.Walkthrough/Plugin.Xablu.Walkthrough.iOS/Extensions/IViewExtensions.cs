using System;
using System.Threading.Tasks;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Splat;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class IViewExtensions
    {
        public static void SetValues<T>(this UIKit.UITextView textview, T control) where T : TextControl
        {
            textview.TextColor = control.TextColor.ToNative();
            textview.Font = UIKit.UIFont.FromName(textview.Font.Name, control.TextSize);
            textview.Text = control.Text;
        }

        public static void SetValues<T>(this UIKit.UILabel textview, T control) where T : TextControl
        {
            textview.TextColor = control.TextColor.ToNative();
            textview.Font = UIKit.UIFont.FromName(textview.Font.Name, control.TextSize);
            textview.Text = control.Text;
        }

        public static async Task SetValues<T>(this UIKit.UIImageView imageView, T control) where T : ImageControl
        {
            var splatImage = await BitmapLoader.Current.LoadFromResource(control.Image, null, null);
            imageView.Image = splatImage.ToNative();
        }
    }
}
