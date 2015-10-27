using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
	public interface IHeightMapSource
	{
		float GetValue(int x, int y);
	}
}
