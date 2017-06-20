﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Plugin.Xablu.Walkthrough;

namespace WalkthroughSample.Droid
{
    [Activity(Label = "WalkthroughSample", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            CrossWalkthrough.Current.Init(this);

            var myClass = new MyClass();

            var button = FindViewById<Button>(Resource.Id.showWalk);
            button.Click += async (sender, e) => await myClass.SetTheme();
        }
    }
}