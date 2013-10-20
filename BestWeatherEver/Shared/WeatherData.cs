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
			switch (Int32.Parse (Type))
			{
			case 1:
				return "Climacons/sun.png";
			case 2:
			case 3:
				return "Climacons/partly_cloudy.png";
			case 4:
				return "Climacons/cloudy.png";
			case 5:
			case 6:
			case 7:
			case 8:
				return "Climacons/day_rain.png";
			case 9:
			case 10:
			case 11:
				return "Climacons/rain.png";
			case 12:
			case 13:
			case 14:
				return "Climacons/snow.png";
			case 15:
				return "Climacons/fog.png";
			default:
				return "Climacons/thunder.png";
			}
		}
	}
}

