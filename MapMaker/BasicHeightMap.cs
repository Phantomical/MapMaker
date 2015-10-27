using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
	public class BasicHeightMap : IHeightMap
	{
		public float[,] HeightArray;

		public void SetPixel(int xpos, int ypos, float heightValue)
		{
			HeightArray[ypos, xpos] = heightValue;
		}
		public float GetPixel(int xpos, int ypos)
		{
			return HeightArray[ypos, xpos];
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
	}
}
