using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MapMaker
{
	public interface IImageSource
	{
		Bitmap GetImageData();
	}
}
