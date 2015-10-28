using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
	public interface IColourMap : IMapData, IImageSource
	{
		Vec4 GetPixel(int xpos, int ypos);
		void SetPixel(int xpos, int ypos, Vec4 value);

		Vec4[,] MapData
		{
			get;
		}
	}
}
