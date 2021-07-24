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
			if (hourlySalary <= 0)
			{
				throw new ArgumentException("Hourly salary must be greater than or equal to 0");
			}
			return (hourlySalary * HOURS_IN_YEAR);
		}

		public decimal GetHourlySalary(decimal annaulSalary)
		{
			if (annaulSalary <= 0)
			{
				throw new ArgumentException("Annual salary must be greater than to 0");
			}
			return annaulSalary / HOURS_IN_YEAR;
		}
	}
}
