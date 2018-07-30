using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.GettingStarted.Service;

namespace UnitTesting.GettingStarted
{
	public class CreditDecision
	{
		private ICreditDecisionService _creditDecisionService;

		public CreditDecision(ICreditDecisionService creditDecisionService)
		{
			_creditDecisionService = creditDecisionService;
		}

		public string MakeCreditDecision(int creditScore)
		{
			return _creditDecisionService.GetCreditDecision(creditScore);
		}
	}
}
