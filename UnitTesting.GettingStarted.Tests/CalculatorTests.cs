using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTesting.GettingStarted.Tests
{
	[TestFixture]
	public class CalculatorTests
	{
		[TestCase(1, 2)]
		[TestCase(2, 3)]
		[TestCase(3, 5)]
		[TestCase(200, 3)]
		public void Add_Always_ReturnExpectedResult(int lhs, int rhs)
		{
			var systemUnderTest = new Calculator();
			var expectedResult = lhs + rhs;
			Assert.That(systemUnderTest.Add(lhs, rhs), Is.EqualTo(expectedResult));
		}

		[TestCase(100, "Declined")]
		[TestCase(549, "Declined")]
		[TestCase(550, "Maybe")]
		[TestCase(674, "Maybe")]
		[TestCase(675, "We look forward to doing business with you!")]
		public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
		{
			var systemUnderTest = new Calculator();
			Assert.That(systemUnderTest.MakeCreditDecision(creditScore), Is.EqualTo(expectedResult));
		}
	}
}
