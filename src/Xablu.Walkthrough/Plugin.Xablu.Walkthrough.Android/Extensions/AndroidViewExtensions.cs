using System;
using Android.Widget;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;
using Splat;

namespace Plugin.Xablu.Walkthrough.Extensions
{
    public static class AndroidViewExtensions
    {
        public static void SetValues<T>(this TextView textview, T control) where T : TextControl
        {
            textview.Text = control.Text;
            textview.TextSize = control.TextSize;
            textview.SetTextColor(control.TextColor.ToNative());
        }
    }
}
