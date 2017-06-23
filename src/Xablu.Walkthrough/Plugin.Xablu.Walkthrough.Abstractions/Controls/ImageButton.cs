using System;

namespace Plugin.Xablu.Walkthrough.Abstractions.Controls
{
    public class ImageButtonControl
    {
        public string Image { get; set; }
        public Action ClickAction;
    }
}