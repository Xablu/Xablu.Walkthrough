﻿using System;

namespace Plugin.Xablu.Walkthrough.Abstractions.Controls
{
    public class BaseControl
    {
        public AnimationType Animation { get; set; } = AnimationType.None;

        public BaseControl()
        {
        }
    }
}