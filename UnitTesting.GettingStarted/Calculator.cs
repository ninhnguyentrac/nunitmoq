﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted
{
	public class Calculator
	{
		public int Add(int lhs, int rhs)
		{
			return lhs + rhs;
		}

		public string MakeCreditDecision(int creditScore)
		{
			if (creditScore < 550)
				return "Declined";
			return creditScore <= 675 ? "Maybe" : "We look forward to doing business with you!";
		}
	}
}
