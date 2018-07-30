using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.Service
{
	public class CreditDecisionService : ICreditDecisionService
	{
		public string GetCreditDecision(int score)
		{
			if (score < 550)
				return "Declined";
			return score <= 675 ? "Maybe" : "We look forward to doing business with you!";
		}
	}
}
