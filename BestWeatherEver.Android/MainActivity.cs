using System;
using BestWeatherEver.Core;
using Android.Graphics.Drawables;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Content;
using System.Threading.Tasks;

namespace BestWeatherEver.Droid
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

			downloadAndPrintWeather ();

			//Set location text
			TextView locationTextView = FindViewById<TextView> (Resource.Id.locationTextView);
			locationTextView.Text = "Göteborg";

			ImageButton yrNoImageButton = FindViewById<ImageButton> (Resource.Id.yrNoButton);
			yrNoImageButton.Touch += delegate
			{
				var uri = Android.Net.Uri.Parse ("http://www.yr.no/stad/Sverige/V%C3%A4stra%20G%C3%B6taland/G%C3%B6teborg/");

				var intent = new Intent (Intent.ActionView, uri); 
				StartActivity (intent);  
			};
		}

		private async void downloadAndPrintWeather ()
		{
			WeatherData weatherData = await yrNoManager.FetchCurrentWeather ();

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

		}
	}
}


