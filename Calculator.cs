using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Calculator : ICalculate
	{
		public double div(int numberone, int numbertow)
		{
			return numbertow/numberone;
		}

		public int mine(int numberone, int numbertow)
		{
			return numbertow - numberone;
		}

		public int mult(int numberone, int numbertow)
		{
			return numbertow * numberone;
		}

		public int plus(int numberone, int numbertow)
		{
			return numbertow+numberone;
		}
	}
}
