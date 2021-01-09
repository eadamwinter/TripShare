using NUnit.Framework;
using TripShare;
using System.Collections.Generic;

namespace Testy.Calculations
{
    public class CalculationTestClass
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MakingPrymitiveCalculation()
        {
            //Arrange
            ITableRepository tableRepository = new MockTableRepository();
            TableInfo tableInfo = tableRepository.GetInformationAboutTable();

            IExpenseRepository mockData = new MockExpenseRepository();
            List<Expense> repo = mockData.GetAllExpenses();

            Calculation calculation = new Calculation(repo, tableInfo);

            //Act
            var result = calculation.CalculateEqualExpense();

            //Assert
            Assert.AreEqual(14.3, result);
            
        }
    }
}
