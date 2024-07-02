using MyApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationTestProject
{
	[TestFixture]
	public class CalculatorTests
	{
		private Calculator calculator;

		[SetUp]
		public void Setup()
		{
			calculator = new Calculator();
		}

		//example 1
		[Test]
		public void Add_ReturnsCorrectSum()
		{
			// Arrange
			int a = 2;
			int b = 3;

			// Act
			int result = calculator.Add(a, b);

			// Assert
			Assert.AreEqual(5, result);
		}

		//example 2: parameterize test
		[TestCase(2, 3, 5)]
		[TestCase(0, 0, 0)]
		[TestCase(-1, 1, 0)]
		[TestCase(-2, -3, -5)]
		[TestCase(100, 200, 300)]
		public void Add_ReturnsCorrectSum(int a, int b, int expectedSum)
		{
			// Act
			int result = calculator.Add(a, b);

			// Assert
			Assert.AreEqual(expectedSum, result);
		}

		[TestCase(10, 2, 5)]
		[TestCase(9, 3, 3)]
		[TestCase(0, 1, 0)]
		[TestCase(-6, -2, 3)]
		[TestCase(-10, 2, -5)]
		public void Divide_ReturnsCorrectQuotient(int a, int b, int expectedQuotient)
		{
			// Act
			int result = calculator.Divide(a, b);

			// Assert
			Assert.AreEqual(expectedQuotient, result);
		}

		[TestCase(10, 0)]
		[TestCase(-1, 0)]
		public void Divide_ByZeroThrowsException(int a, int b)
		{
			// Act & Assert
			Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
		}

	}
}
