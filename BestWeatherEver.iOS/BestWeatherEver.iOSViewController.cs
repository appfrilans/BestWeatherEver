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

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			WeatherData weatherData = yrNoManager.FetchCurrentWeather ();
			weatherImage.Image = UIImage.FromFile (weatherData.GetClimaconIconPath());
			thermometerImage.Image = UIImage.FromFile ("Climacons/thermometer.png");
			thermometerLabel.Text = String.Format (@"{0}°", weatherData.Temperature);
			windImage.Image = UIImage.FromFile ("Climacons/wind.png");
			windLabel.Text = String.Format (@"{0}", weatherData.WindDirection);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

