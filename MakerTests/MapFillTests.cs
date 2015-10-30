using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapMaker;

using IModule = LibNoise.IModule;

namespace MakerTests
{
	[TestClass]
	public class MapFillTests
	{
		[TestMethod]
		public void HeightFillTest()
		{
			const double ExpectedValue = 5.0;

			IModule constant = new MapMaker.LibNoiseExt.Constant(ExpectedValue);

			BasicHeightMap Map = new BasicHeightMap(32, 32);

			HeightMapBuilder Builder = new HeightMapBuilder(Map, new MapMaker.HeightGenerators.LibNoiseGenerator(constant));

			Builder.FillMap();

			for (int y = 0; y < Map.Height; y++)
			{
				for (int x = 0; x < Map.Width; x++)
				{
					Assert.AreEqual(ExpectedValue, Map.GetPixel(x, y));
				}
			}
		}
	}
}
