using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BestWeatherEver.Core;
using Android.Graphics.Drawables;

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

			//Set weather text
			TextView weatherTextView = FindViewById<TextView> (Resource.Id.weatherLabel);
			weatherTextView.Text = weatherData.TypeString ();

			//Set wind text
			TextView windTextView = FindViewById<TextView> (Resource.Id.windLabel);
			windTextView.Text = weatherData.WindDirectionString ();

			//Set temperature text
			TextView temperatureTextView = FindViewById<TextView> (Resource.Id.degreeLabel);
			temperatureTextView.Text = weatherData.Temperature + "°";

			//Set weather image
			ImageView weatherImageView = FindViewById<ImageView> (Resource.Id.weatherImageView);
			String weatherDrawableName = weatherData.GetIconPath ().Replace (".png", "");
			int weatherResourceId = (int)typeof(Resource.Drawable).GetField (weatherDrawableName).GetValue (null);
			weatherImageView.SetImageResource (weatherResourceId);
	
			//Set location text
			TextView locationTextView = FindViewById<TextView> (Resource.Id.locationTextView);
			locationTextView.Text = "Göteborg";
		}
	}
}


