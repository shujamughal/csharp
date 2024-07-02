using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
	public class Calculator
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Divide(int a, int b)
		{
			if (b == 0)
				throw new DivideByZeroException("Division by zero is not allowed.");

			return a / b;
		}
	}

}
