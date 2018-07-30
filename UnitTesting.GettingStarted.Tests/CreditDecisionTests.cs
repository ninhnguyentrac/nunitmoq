using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework.Internal;
using NUnit.Framework;
using UnitTesting.GettingStarted.Service;

namespace UnitTesting.GettingStarted.Tests
{
	[TestFixture]
	public class CreditDecisionTests
	{
		private Mock<ICreditDecisionService> mockCreditDecisionService;
		private CreditDecision systemUnderTest;

		[TestCase(100, "Declined")]
		[TestCase(549, "Declined")]
		[TestCase(550, "Maybe")]
		[TestCase(674, "Maybe")]
		[TestCase(675, "We look forward to doing business with you!")]
		public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
		{
			mockCreditDecisionService = new Mock<ICreditDecisionService>(MockBehavior.Strict);
			mockCreditDecisionService.Setup(p => p.GetCreditDecision(creditScore)).Returns(expectedResult);

			systemUnderTest = new CreditDecision(mockCreditDecisionService.Object);
			var result = systemUnderTest.MakeCreditDecision(creditScore);

			Assert.That(result, Is.EqualTo(expectedResult));

			mockCreditDecisionService.VerifyAll();
		}
	}
}
