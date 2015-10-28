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
	public class BasicColourMap : IColourMap
	{
		//2D array of pixels
		public readonly Vec4[,] ColourArray;

		public void SetPixel(int xpos, int ypos, Vec4 heightValue)
		{
			ColourArray[xpos, ypos] = heightValue;
		}
		public Vec4 GetPixel(int xpos, int ypos)
		{
			return ColourArray[xpos, ypos];
		}

		public int Width
		{
			get
			{
				return ColourArray.GetLength(1);
			}
		}
		public int Height
		{
			get
			{
				return ColourArray.GetLength(0);
			}
		}

		public BasicColourMap(int xsize, int ysize)
		{
			ColourArray = new Vec4[xsize, ysize];
		}

		public Bitmap GetImageData()
		{
			//Create the bitmap
			Bitmap bmp = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
			BitmapData data = bmp.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.WriteOnly, PixelFormat.Format16bppGrayScale);

			//Copy width and height for faster access
			int width = Width;
			int height = Height;

			//Create the data that will be copied into the image
			byte[] colours = new byte[Width * Height * 4];

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					//Convert all f32 pixel values to byte values
					Vec4 pval = GetPixel(x, y);
					int index = y * width + x;

					colours[index] = (byte)(pval.R * 256f);
					colours[index + 1] = (byte)(pval.G * 256f);
					colours[index + 2] = (byte)(pval.B * 256f);
					colours[index + 3] = (byte)(pval.A * 256f);
				}
			}

			//Copy the new values into the buffer
			Marshal.Copy(colours, 0, data.Scan0, colours.Length);

			//Let the bitmap manage its memory again, otherwise memory will leak
			bmp.UnlockBits(data);

			return bmp;
		}
	}
}
