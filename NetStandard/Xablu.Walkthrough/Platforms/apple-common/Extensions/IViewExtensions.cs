﻿using System.Threading.Tasks;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Splat;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class IViewExtensions
    {
        public static void SetBaseControl(this UIKit.UIView view, BaseControl control)
        {
            if (view == null)
                return;

            view.Hidden = control?.Hidden ?? true;
        }

        public static void SetControl(this UIKit.UITextView textview, TextControl control)
        {
            textview.SetBaseControl(control);

            if (control == null)
                return;

            textview.TextColor = control.TextColor.ToNative();
            textview.Font = UIKit.UIFont.FromName(textview.Font.Name, control.TextSize);
            textview.Text = control.Text;
            switch (control.TextStyle)
            {
                case 1:
                    textview.Font = StyleText(textview.Font, UIFontDescriptorSymbolicTraits.Bold);
                    break;
                case 2:
                    textview.Font = StyleText(textview.Font, UIFontDescriptorSymbolicTraits.Italic);
                    break;
            }
        }

        public static void SetControl(this UIKit.UILabel textview, TextControl control)
        {
            textview.SetBaseControl(control);

            if (control == null)
                return;

            textview.TextColor = control.TextColor.ToNative();
            textview.Font = UIKit.UIFont.FromName(textview.Font.Name, control.TextSize);
            textview.Text = control.Text;
            switch (control.TextStyle)
            {
                case 1:
                    textview.Font = StyleText(textview.Font, UIFontDescriptorSymbolicTraits.Bold);
                    break;
                case 2:
                    textview.Font = StyleText(textview.Font, UIFontDescriptorSymbolicTraits.Italic);
                    break;
            }
        }

        public static async Task SetControl(this UIKit.UIImageView imageView, ImageControl control)
        {
            imageView.SetBaseControl(control);

            if (control == null)
                return;

            imageView.Image = await GetImage(control.Image);
        }

        public static async Task SetControl(this UIKit.UIButton button, ImageButtonControl control, bool handleTouchUpInside = true)
        {
            button.SetBaseControl(control);

            if (control == null)
                return;

            button.SetImage(await GetImage(control.Image), UIControlState.Normal);

            if (handleTouchUpInside && control.ClickAction != null)
            {
                button.TouchUpInside += (sender, e) => control?.ClickAction();
            }
        }

        public static void SetControl(this UIKit.UIButton button, ButtonControl control, bool handleTouchUpInside = true)
        {
            button.SetBaseControl(control);

            if (control == null)
                return;

            button.SetTitleColor(control.TextColor.ToNative(), UIKit.UIControlState.Normal);
            button.Font = UIKit.UIFont.FromName(button.Font.Name, control.TextSize);
            button.SetTitle(control.Text, UIKit.UIControlState.Normal);
            button.BackgroundColor = control.BackgroundColor.ToNative();

            if (handleTouchUpInside && control.ClickAction != null)
            {
                button.TouchUpInside += (sender, e) => control?.ClickAction();
            }
        }

        public static void SetControl(this UIKit.UIPageControl pageControl, PageControl control)
        {
            pageControl.SetBaseControl(control);

            if (control == null)
                return;

            pageControl.PageIndicatorTintColor = control.UnSelectedPageColor.ToNative();
            pageControl.CurrentPageIndicatorTintColor = control.SelectedPageColor.ToNative();
        }

        private static async Task<UIImage> GetImage(string imageRes)
        {
            if (string.IsNullOrEmpty(imageRes))
                return new UIImage();

            var image = await BitmapLoader.Current.LoadFromResource(imageRes, null, null);
            return image.ToNative();
        }

        private static UIFont StyleText(UIFont currentFont, UIFontDescriptorSymbolicTraits symbolicTraits)
        {
            var descriptor = currentFont.FontDescriptor.CreateWithTraits(symbolicTraits);
            return UIFont.FromDescriptor(descriptor, 0);
        }
    }
}
