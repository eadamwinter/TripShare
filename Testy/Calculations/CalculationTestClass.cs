using NUnit.Framework;
using TripShare;
using System.Collections.Generic;

namespace Testy.Calculations
{
    public class CalculationTestClass
    {
        public TableInfo tableInfo { get; set; } 
        public List<Expense> repo { get; set; }


        [SetUp]
        public void Setup()
        {
            ITableRepository tableRepository = new MockTableRepository();
            tableInfo = tableRepository.GetInformationAboutTable();

            IExpenseRepository mockData = new MockExpenseRepository();
            repo = mockData.GetAllExpenses();
        }

        [Test]
        public void MakingPrymitiveCalculation()
        {
            //Arrange
            ICalculationMethod calculationMethod = new CalculationMethod();

            Calculation calculation = new Calculation(repo, tableInfo, calculationMethod);

            //Act
            var result = calculation.CalculateEqualExpense();

            //Assert
            Assert.AreEqual(14.35, result);
            
        }
        [Test]
        public void DictionaryTest_EverybodyInvolved()
        {
            //Arrange
            ICalculationMethod calculationMethod = new CalculationMethod();

            Calculation calculation = new Calculation(repo, tableInfo, calculationMethod);

            //Act
            var dict = calculation.CreateMemberExpenseDictionary();
            var expecteddict = new Dictionary<string, decimal>() { { "Igor_Adam", 4.20m }, { "Heniek_Adam", 4.20m } };
            expecteddict.Add("Adam_Igor", 2.05m);
            expecteddict.Add("Heniek_Igor", 2.05m);
            expecteddict.Add("Adam_Heniek", 8.10m);
            expecteddict.Add("Igor_Heniek", 8.10m);

            var firstvalue = dict["Igor_Heniek"];


            //Assert
            Assert.IsNotNull(dict);
            Assert.AreEqual(expecteddict.Count, dict.Count);
            Assert.Contains("Igor_Adam", dict.Keys);
            Assert.AreEqual(8.10m, firstvalue);
        }

        [Test]
        public void DictionaryTest_OnePersonInvolved()
        {
            //Arrange
            List<Expense> expenses = new List<Expense>();
            expenses.Add(new Expense(1, "Adam", 12.60m, new List<string>() { "Igor" }));

            ICalculationMethod calculationMethod = new CalculationMethod();

            Calculation calculation = new Calculation(expenses, tableInfo, calculationMethod);

            //Act
            var dict = calculation.CreateMemberExpenseDictionary();
            var expecteddict = new Dictionary<string, decimal>() { { "Igor_Adam", 6.30m } };


            //Assert
            Assert.IsNotNull(dict);
            Assert.AreEqual(expecteddict.Count, dict.Count);
            Assert.Contains("Igor_Adam", dict.Keys);
            Assert.Contains(6.30m, dict.Values);

        }
        [Test]
        public void CreateStringForDictTest()
        {
            //Arrange
            CalculationMethod calculationMethod = new CalculationMethod();

            Calculation calculation = new Calculation(repo, tableInfo, calculationMethod);

            //Act
            var exp = repo[0];
            string singleStringForDict = calculationMethod.CreateStringForDictionary(exp, 0);
            string expectedString = "Igor_Adam";

            //Assert
            Assert.AreEqual(expectedString, singleStringForDict);
        }
    }
}
