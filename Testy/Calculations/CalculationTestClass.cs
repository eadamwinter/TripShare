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
            ICalculationMethod calculationMethod = new CalculationMethod();

            ITableRepository tableRepository = new MockTableRepository();
            TableInfo tableInfo = tableRepository.GetInformationAboutTable();

            IExpenseRepository mockData = new MockExpenseRepository();
            List<Expense> repo = mockData.GetAllExpenses();

            Calculation calculation = new Calculation(repo, tableInfo, calculationMethod);

            //Act
            var result = calculation.CalculateEqualExpense();

            //Assert
            Assert.AreEqual(14.3, result);
            
        }
        [Test]
        public void CreatePrymitiveDictionary()
        {
            //Arrange
            ICalculationMethod calculationMethod = new CalculationMethod();

            ITableRepository tableRepository = new MockTableRepository();
            TableInfo tableInfo = tableRepository.GetInformationAboutTable();

            IExpenseRepository mockData = new MockExpenseRepository();
            List<Expense> repo = mockData.GetAllExpenses();

            Calculation calculation = new Calculation(repo, tableInfo, calculationMethod);

            //Act
            var dict = calculation.CreateMemberExpenseDictionary();
            var expecteddict = new Dictionary<string, double>() { { "Adam", 15.40 }, { "Igor", 13.20 } };

            //Assert
            Assert.IsNotNull(dict);
            Assert.AreEqual(expecteddict, dict);
        }
        [Test]
        public void CreatePrymitiveDebts()
        {
            //Arrange
            ICalculationMethod calculationMethod = new CalculationMethod();

            ITableRepository tableRepository = new MockTableRepository();
            TableInfo tableInfo = tableRepository.GetInformationAboutTable();

            IExpenseRepository mockData = new MockExpenseRepository();
            List<Expense> repo = mockData.GetAllExpenses();

            Calculation calculation = new Calculation(repo, tableInfo, calculationMethod);

            //Act
            var wynik = calculation.CalculatePrymitiveDebts();
            

            //Assert
            Assert.IsNotNull(wynik);
            Assert.AreEqual("alejaja", wynik);
        }
    }
}
