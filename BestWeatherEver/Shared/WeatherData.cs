using System;

namespace BestWeatherEver.Core
{
	public class WeatherData
	{
		public String Type { get; set; }

		public String WindDirection { get; set; }

		public String Temperature { get; set; }

		public WeatherData ()
		{

		}

		public String GetClimaconIconPath ()
		{
			if (Int32.Parse(Type) == 1) {
				return "Climacons/sun.png";
			}
			else if (Int32.Parse(Type) == 2 || Int32.Parse(Type) == 3) {
				return "Climacons/partly_cloudy.png";
			}
			else if (Int32.Parse(Type) == 4) {
				return "Climacons/cloudy.png";
			}
			else if (Int32.Parse(Type) == 5 || Int32.Parse(Type) == 6 || Int32.Parse(Type) == 7 || Int32.Parse(Type) == 8) {
				return "Climacons/day_rain.png";
			}
			else if (Int32.Parse(Type) == 9 || Int32.Parse(Type) == 10 || Int32.Parse(Type) == 11) {
				return "Climacons/rain.png";
			}
			else if (Int32.Parse(Type) == 12 || Int32.Parse(Type) == 13 || Int32.Parse(Type) == 14) {
				return "Climacons/snow.png";
			}
			else if (Int32.Parse(Type) == 15) {
				return "Climacons/fog.png";
			}
			else {
				return "Climacons/thunder.png";
			}
		}

		public String GetWindDirection ()
		{
			//N, NNE, NE, ENE, E, ESE, SE, SSE, S, SSW, SW, WSW, W, WNW, NW, NNW.
			return WindDirection;
		}
	}
}

