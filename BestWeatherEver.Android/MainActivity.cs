using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BestWeatherEver.Core;

namespace BestWeatherEver.Android
{
	[Activity (Label = "BestWeatherEver.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		YrNoManager yrNoManager;
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			yrNoManager = new YrNoManager ();

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate
			{
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


