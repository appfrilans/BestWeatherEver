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
	[Activity (Label = "BestWeatherEver", MainLauncher = true, Theme = "@android:style/Theme.Light.NoTitleBar")]
	public class MainActivity : Activity
	{
		YrNoManager yrNoManager;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			yrNoManager = new YrNoManager ();
			WeatherData weatherData = yrNoManager.FetchCurrentWeather ();
			// Get our button from the layout resource,
			// and attach an event to it
			TextView weatherTextView = FindViewById<TextView> (Resource.Id.weatherLabel);
			weatherTextView.Text = weatherData.TypeString ();

			TextView windTextView = FindViewById<TextView> (Resource.Id.windLabel);
			windTextView.Text = weatherData.WindDirectionString ();

			TextView temperatureTextView = FindViewById<TextView> (Resource.Id.degreeLabel);
			temperatureTextView.Text = weatherData.Temperature;

		}
	}
}


