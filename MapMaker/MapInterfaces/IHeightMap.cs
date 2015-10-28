using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
	public interface IHeightMap : IMapData, IImageSource
	{
		void SetPixel(int xpos, int ypos, float heightValue);
		float GetPixel(int xpos, int ypos);

		float[,] MapData
		{
			get;
		}
	}
}
