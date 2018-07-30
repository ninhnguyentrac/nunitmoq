using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.Service
{
	public interface ICreditDecisionService
	{
		string GetCreditDecision(int score);
	}
}
