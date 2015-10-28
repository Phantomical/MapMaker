using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapMaker;

namespace MakerTests
{
	[TestClass]
	public class BasicHeightMapTest
	{
		[TestMethod]
		public void HeightMapSizeTest()
		{
			BasicHeightMap Map = new BasicHeightMap(32, 64);

			Assert.AreEqual(Map.Width, 32);
			Assert.AreEqual(Map.Height, 64);
		}

		[TestMethod]
		public void ColourMapSizeTest()
		{
			BasicColourMap Map = new BasicColourMap(32, 64);

			Assert.AreEqual(Map.Width, 32);
			Assert.AreEqual(Map.Height, 64);
		}
	}
}
