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

			String weatherText = yrNoManager.FetchCurrentWeather ();
			weatherLabel.Text = weatherText;

			// Perform any additional setup after loading the view, typically from a nib.
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

