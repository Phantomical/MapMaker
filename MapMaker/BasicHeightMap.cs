using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
	public class BasicHeightMap : IHeightMap
	{
		public readonly float[,] HeightArray;

		public void SetPixel(int xpos, int ypos, float heightValue)
		{
			HeightArray[xpos, ypos] = heightValue;
		}
		public float GetPixel(int xpos, int ypos)
		{
			return HeightArray[xpos, ypos];
		}

		public int Width
		{
			get
			{
				return HeightArray.GetLength(1);
			}
		}
		public int Height
		{
			get 
			{
				return HeightArray.GetLength(0);
			}
		}

		public BasicHeightMap(int xsize, int ysize)
		{
			HeightArray = new float[xsize, ysize];
		}
	}
}
