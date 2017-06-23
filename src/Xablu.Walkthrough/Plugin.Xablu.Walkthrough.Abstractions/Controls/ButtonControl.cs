using System;
using System.Drawing;

namespace Plugin.Xablu.Walkthrough.Abstractions.Controls
{
    public class ButtonControl : TextControl
    {
        public Color BackgroundColor;
        public Action ClickAction;
    }
}