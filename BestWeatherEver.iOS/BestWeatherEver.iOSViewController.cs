using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using BestWeatherEver.Core;

namespace BestWeatherEver.iOS
{
	public partial class BestWeatherEver_iOSViewController : UIViewController
	{
		YrNoManager yrNoManager;

		public BestWeatherEver_iOSViewController (IntPtr handle) : base (handle)
		{
			yrNoManager = new YrNoManager ();
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			downloadAnPrintWeather ();

			//Set Location Text
			locationLabel.Text = "Göteborg";

			yrNoButton.TouchUpInside += delegate
			{
				UIApplication.SharedApplication.OpenUrl (new NSUrl ("http://www.yr.no/stad/Sverige/V%C3%A4stra%20G%C3%B6taland/G%C3%B6teborg/"));
			};
		}

		private async void downloadAnPrintWeather ()
		{
			WeatherData weatherData = await yrNoManager.FetchCurrentWeather ();

			//Set Weather Image
			weatherImage.Image = UIImage.FromFile (weatherData.GetClimaconIconPath ());

			//Set Termometer Image
			thermometerImage.Image = UIImage.FromFile ("Climacons/thermometer.png");

			//Set Temperature Text
			thermometerLabel.Text = String.Format (@"{0}°", weatherData.Temperature);

			//Set wind Image
			windImage.Image = UIImage.FromFile ("Climacons/wind.png");

			//Set wind Text
			windLabel.Text = String.Format (@"{0}", weatherData.WindDirectionString ());

			//Set Weather Text
			weatherLabel.Text = weatherData.TypeString ();

		}

		#endregion

	}
}

