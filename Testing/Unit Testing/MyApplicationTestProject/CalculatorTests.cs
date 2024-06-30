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
	}
}
