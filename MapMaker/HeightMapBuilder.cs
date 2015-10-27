using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
	public class HeightMapBuilder
	{
		public IHeightMap Map;
		public IHeightMapSource Source;

		public void FillMap()
		{
			int width = Map.Width;
			int height = Map.Height;

			for(int y = 0; y < width; y++)
			{
				for(int x = 0; x < height; x++)
				{
					Map.SetPixel(x, y, Source.GetValue(x, y));
				}
			}
		}

		public HeightMapBuilder()
		{
			Map = null;
			Source = null;
		}
		public HeightMapBuilder(IHeightMap map, IHeightMapSource src)
		{
			Map = map;
			Source = src;
		}
	}
}
