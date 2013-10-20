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
		MonoTouch.UIKit.UILabel weatherLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (weatherLabel != null)
			{
				weatherLabel.Dispose ();
				weatherLabel = null;
			}
		}
	}
}
