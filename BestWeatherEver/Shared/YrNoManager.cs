using System;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace BestWeatherEver.Core
{
	public class YrNoManager
	{
		private WeatherData lastFetchedWeatherData;

		public YrNoManager ()
		{

		}

		public async Task<WeatherData> FetchCurrentWeather ()
		{
			String xml = await fetchXML ();
			if (xml == null)
			{
				return null;
			}
			lastFetchedWeatherData = mapXMLToWeatherData (xml);
			if (lastFetchedWeatherData == null)
			{
				return null;
			}

			return lastFetchedWeatherData;
		}

		private async Task<String> fetchXML ()
		{
			String url = "http://www.yr.no/place/Sweden/V%C3%A4stra%20G%C3%B6taland/G%C3%B6teborg/forecast.xml";
			HttpClient request = new HttpClient ();

			Task<string> response = request.GetStringAsync (url);

			String content = await response;

			if (response.Status != TaskStatus.RanToCompletion)
			{
				Console.Out.WriteLine ("Error fetching data");
				return null;
			}

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

		private WeatherData mapXMLToWeatherData (string xml)
		{
			XDocument doc = XDocument.Parse (xml);
			var weatherList = doc.Root.Descendants ("time")
				.Select (x => new WeatherData () {
				Type = x.Element ("symbol").Attribute ("number").Value,
				WindDirection = x.Element ("windDirection").Attribute ("code").Value,
				Temperature = x.Element ("temperature").Attribute ("value").Value,
			});

			return weatherList.First ();
		}
	}
}

