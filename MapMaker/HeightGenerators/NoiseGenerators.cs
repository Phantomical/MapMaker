using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibNoise;

namespace MapMaker.HeightGenerators
{
	public class LibNoiseGenerator : IHeightMapSource
	{
		public IModule Module;

		public float GetValue(int x, int y)
		{
			return (float)Module.GetValue((double)x, 0.0, (double)y);
		}

		public LibNoiseGenerator(IModule module)
		{
			Module = module;
		}
	}

	public static class NoiseGenerators
	{


	}
}
