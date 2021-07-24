using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculatorCore;
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
		public void GetAnnualSalaryTest()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal annualSalary = salaryCalculator.GetAnnualSalary(50);

			//Assert
			Assert.AreEqual(104000, annualSalary);
		}

		[TestMethod]
		public void GetHourlySalaryTest()
		{
			//Arrange
			SalaryCalculator salaryCalculator = new SalaryCalculator();

			//Act
			decimal hourlySalary = salaryCalculator.GetHourlySalary(104000);

			//Assert
			Assert.AreEqual(50, hourlySalary);
		}
	}
}
