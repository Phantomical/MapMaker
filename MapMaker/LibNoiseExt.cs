using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibNoise;

namespace MapMaker.LibNoiseExt
{
	public class AddToInput : IModule
	{
		public IModule AddSource;
		public IModule InputModule;

		public AddToInput(IModule adder, IModule input)
		{
			AddSource = adder;
			InputModule = input;
		}

		double GetValue(double x, double y, double z)
		{
			double addand = AddSource.GetValue(x, y, z);
			return InputModule.GetValue(x + addand, y + addand, z + addand);
		}
	}
	public class ScaleInput : IModule
	{
		public IModule InputModule;
		public IModule ScaleModule;

		public ScaleInput(IModule input, IModule scale)
		{
			InputModule = input;
			ScaleModule = scale;
		}

		public double GetValue(double x, double y, double z)
		{
			double scale = ScaleModule.GetValue(x, y, z);
			return InputModule.GetValue(x * scale, y * scale, z * scale);
		}
	}

	/// <summary>
	/// Equivalent to <code>1/Source</code>
	/// </summary>
	public class Inverse : IModule
	{
		public IModule Source;

		public Inverse(IModule src)
		{
			Source = src;
		}

		public double GetValue(double x, double y, double z)
		{
			return 1.0 / Source.GetValue(x, y, z);
		}
	}

	/// <summary>
	/// Adapter class that bridges between regular functions and Modules
	/// </summary>
	public class Function : IModule
	{
		public Func<double, double, double, double> Func;

		public Function(Func<double, double, double, double> func)
		{
			Func = func;
		}

		public double GetValue(double x, double y, double z)
		{
			return Func(x, y, z);
		}
	}

	public class Sin : IModule
	{
		IModule Source;

		public Sin(IModule Src)
		{
			Source = Src;
		}

		public double GetValue(double x, double y, double z)
		{
			return System.Math.Sin(Source.GetValue(x, y, z));
		}
	}
	public class Cos : IModule
	{
		IModule Source;

		public Cos(IModule Src)
		{
			Source = Src;
		}

		public double GetValue(double x, double y, double z)
		{
			return System.Math.Cos(Source.GetValue(x, y, z));
		}
	}
	public class Tan : IModule
	{
		IModule Source;

		public Tan(IModule Src)
		{
			Source = Src;
		}

		public double GetValue(double x, double y, double z)
		{
			return System.Math.Tan(Source.GetValue(x, y, z));
		}
	}
	public class Pow : IModule
	{
		public IModule Module1;
		public IModule Module2;

		public Pow(IModule m1, IModule m2)
		{
			Module1 = m1;
			Module2 = m2;
		}

		public double GetValue(double x, double y, double z)
		{
			return System.Math.Pow(Module1.GetValue(x, y, z), Module2.GetValue(x, y, z));
		}
	}
	public class Abs : IModule
	{
		public IModule Source;

		public Abs(IModule src)
		{
			Source = src;
		}

		public double GetValue(double x, double y, double z)
		{
			return System.Math.Abs(Source.GetValue(x, y, z));
		}
	}
}
