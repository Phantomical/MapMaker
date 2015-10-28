using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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

		public Bitmap GetImageData()
		{
			Bitmap bmp = new Bitmap(Width, Height, PixelFormat.Format16bppGrayScale);
			BitmapData data = bmp.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.WriteOnly, PixelFormat.Format16bppGrayScale);
			
			int width = Width;
			int height = Height;

			ushort[] bdata = new ushort[Width * Height];

			float max = (float)ushort.MaxValue;

			for(int y = 0; y < height; y++)
			{
				for(int x = 0; x < height; x++)
				{
					bdata[y * Width + x] = (ushort)(Math.Max(GetPixel(x, y) * max, 0f));
				}
			}

			byte[] array = new byte[sizeof(ushort) * bdata.Length];
			Buffer.BlockCopy(bdata, 0, array, 0, array.Length);

			Marshal.Copy(array, 0, data.Scan0, array.Length);

			bmp.UnlockBits(data);

			return bmp;
		}
	}
}
