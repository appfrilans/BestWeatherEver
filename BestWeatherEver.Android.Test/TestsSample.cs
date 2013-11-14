using System;
using NUnit.Framework;
using BestWeatherEver.Core;

namespace BestWeatherEver.Android.Test
{
	[TestFixture]
	public class TestsSample
	{
		YrNoManager yr;

		[SetUp]
		public void Setup ()
		{
			yr = new YrNoManager ();
		}

		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void Pass ()
		{
			Console.WriteLine ("test1");
			Assert.True (yr != null); 
		}

		[Test]
		public void Fail ()
		{
			Assert.False (true);
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}

		[Test]
		public void Inconclusive ()
		{
			Assert.Inconclusive ("Inconclusive");
		}
	}
}

