// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace BestWeatherEver.iOS
{
	[Register ("BestWeatherEver_iOSViewController")]
	partial class BestWeatherEver_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel locationLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView thermometerImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel thermometerLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView weatherImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel weatherLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView windImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel windLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton yrNoButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (locationLabel != null)
			{
				locationLabel.Dispose ();
				locationLabel = null;
			}

			if (thermometerImage != null)
			{
				thermometerImage.Dispose ();
				thermometerImage = null;
			}

			if (thermometerLabel != null)
			{
				thermometerLabel.Dispose ();
				thermometerLabel = null;
			}

			if (weatherImage != null)
			{
				weatherImage.Dispose ();
				weatherImage = null;
			}

			if (weatherLabel != null)
			{
				weatherLabel.Dispose ();
				weatherLabel = null;
			}

			if (windImage != null)
			{
				windImage.Dispose ();
				windImage = null;
			}

			if (windLabel != null)
			{
				windLabel.Dispose ();
				windLabel = null;
			}

			if (yrNoButton != null)
			{
				yrNoButton.Dispose ();
				yrNoButton = null;
			}
		}
	}
}
