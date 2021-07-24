using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculatorCore;
using System;

namespace SalaryCalculatorTest
{
	/*
		To get hourly, divide annual salary by 2080
		$100,006.40 / 2080 = 48.08 hr

		To get annual, multiply hourly salary by 2080
		$48.08 * 2080 = $100,006.40
	 */

	[TestClass]
	public class SalaryCalculatorTest
	{
		[TestMethod]
		public void GetAnnualSalary_PositiveValue_ValidResult()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal annualSalary = salaryCalculator.GetAnnualSalary(50.00m);

			//Assert
			Assert.AreEqual(104000.00m, annualSalary);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetAnnualSalary_ZeroValue_ValidResult()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal annualSalary = salaryCalculator.GetAnnualSalary(0);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetAnnualSalary_NegativeValue_ArgumentExceptionThrown()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal annualSalary = salaryCalculator.GetAnnualSalary(-50.00m);

			//Assert
		}

		[TestMethod]
		public void GetHourlySalary_PositiveValue_ValidResult()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal hourlySalary = salaryCalculator.GetHourlySalary(104000.00m);

			//Assert
			Assert.AreEqual(50.00m, hourlySalary);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetHourlySalary_ZeroValue_ValidResult()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal hourlySalary = salaryCalculator.GetHourlySalary(0);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetHourlySalary_NegativeValue_ValidResult()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal hourlySalary = salaryCalculator.GetHourlySalary(-104000.00m);
		}
	}
}
