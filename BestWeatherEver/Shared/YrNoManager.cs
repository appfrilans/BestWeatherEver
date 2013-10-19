using System;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace BestWeatherEver.Core
{
	public class YrNoManager
	{
		private WeatherData lastFetchedWeatherData;

		public YrNoManager ()
		{
		}

		public String FetchCurrentWeather ()
		{
			String xml = fetchXML ();
			if (xml != null)
			{
				lastFetchedWeatherData = mapXMLToWeatherData (xml);
				if (lastFetchedWeatherData != null)
				{
					return String.Format (@"Temp: {0} Wind: {1} Weather: {2}", lastFetchedWeatherData.Temperature, lastFetchedWeatherData.WindDirection, lastFetchedWeatherData.Type);
				}
			}
			return "";
		}

		private String fetchXML ()
		{
			var request = HttpWebRequest.Create ("http://www.yr.no/place/Sweden/V%C3%A4stra%20G%C3%B6taland/G%C3%B6teborg/forecast.xml");
			request.ContentType = "application/xml";
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine ("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd ();
					if (string.IsNullOrWhiteSpace (content))
					{
						Console.Out.WriteLine ("Response contained empty body...");
						return null;
					}
					else
					{
						Console.Out.WriteLine ("Response Body: \r\n {0}", content);
						return content;
					}

				
				}
			}
		}

		private WeatherData mapXMLToWeatherData (string xml)
		{
			/*XDocument doc = XDocument.Parse (xml);
			var result = doc.Root.Descendants ("tabular");
			XElement firstWeather = result.First ();

			XElement symbol = firstWeather.Element ("symbol");
			XElement windDirection = firstWeather.Element ("windDirection");
			XElement temperature = firstWeather.Element ("temperature");*/

			WeatherData weatherData = new WeatherData ();
			weatherData.Type = "9"; //symbol.Attribute ("number").Value;
			weatherData.WindDirection = "ESE"; //(string)windDirection.Attribute ("code");
			weatherData.Temperature = "9"; //(string)windDirection.Attribute ("value");

			return weatherData;
		}
	}
}

