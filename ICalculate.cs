using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal interface ICalculate
	{
		int plus(int numberone, int numbertow);
		int mine(int numberone, int numbertow);
		double div(int numberone, int numbertow);
		int mult(int numberone, int numbertow);
	}
}
