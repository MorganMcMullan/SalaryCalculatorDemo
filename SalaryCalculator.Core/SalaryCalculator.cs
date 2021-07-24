using System;

namespace SalaryCalculatorCore
{
	/// <summary>
	/// Converts salary between hourly and annual based on hours in a year.
	/// </summary>
	public class SalaryCalculator
	{	
		private const int HOURS_IN_YEAR = 2080;

		public decimal GetAnnualSalary(decimal hourlySalary)
		{
			return hourlySalary * HOURS_IN_YEAR;
		}

		public decimal GetHourlySalary(decimal annaulSalary)
		{
			return annaulSalary / HOURS_IN_YEAR;
		}
	}
}
