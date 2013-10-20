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

		public String WindDirectionString ()
		{
			String direction = WindDirection;

			if (direction == "N")
				return "Norr";

			direction = direction.Replace ("N", "1").Replace ("S", "2").Replace ("W", "3").Replace ("E", "4");
			direction = direction.Replace ("1", "nord").Replace ("2", "syd").Replace ("3", "väst").Replace ("4", "ost");

			return Helper.UppercaseFirst (direction);
		}

		public String TypeString ()
		{
			String simpleType = Type.Replace ("d", "").Replace ("n", "").Replace ("m", "");
			switch (simpleType)
			{
			case "1":
				return "Klart";
			case "2":
				return "Halvklart";
			case "3":
				return "Växlande molnighet";
			case "4":
				return "Mulet";
			case "5":
				return "Regnskurar";
			case "6":
				return "Regnskurar och åska";
			case "7":
				return "Lätt snöblandat regn";
			case "8":
				return "Snöbyar";
			case "9":
				return "Regn";
			case "10":
				return "Mycket regn";
			case "11":
				return "Regn och åska";
			case "12":
				return "Snöblandat regn";
			case "13":
				return "Snö";
			case "14":
				return "Snö och åska";
			case "15":
				return "Dimma";
			case "20":
				return "Lätt molnighet och åska";
			case "21":
				return "Snö och åska";
			case "22":
				return "Regn och åska";
			case "23":
				return "Snöblandat regn och åska";
			default:
				return "";
			}
		}

		public String GetClimaconIconPath ()
		{
			if (Int32.Parse (Type) == 1) {
				return "Climacons/sun.png";
			} else if (Int32.Parse (Type) == 2 || Int32.Parse (Type) == 3) {
				return "Climacons/partly_cloudy.png";
			} else if (Int32.Parse (Type) == 4) {
				return "Climacons/cloudy.png";
			} else if (Int32.Parse (Type) == 5 || Int32.Parse (Type) == 6 || Int32.Parse (Type) == 7 || Int32.Parse (Type) == 8) {
				return "Climacons/day_rain.png";
			} else if (Int32.Parse (Type) == 9 || Int32.Parse (Type) == 10 || Int32.Parse (Type) == 11) {
				return "Climacons/rain.png";
			} else if (Int32.Parse (Type) == 12 || Int32.Parse (Type) == 13 || Int32.Parse (Type) == 14) {
				return "Climacons/snow.png";
			} else if (Int32.Parse (Type) == 15) {
				return "Climacons/fog.png";
			} else {
				return "Climacons/thunder.png";
			}
		}
	}
}

