using NUnit.Framework;
using TripShare;
using WebTripShare;
using System.Collections.Generic;
using System.Linq;
using Moq;

namespace Testy.Calculations
{
    public class CalculationTestClass
    {
        public TableInfo tableInfo { get; set; } 
        public List<Expense> repo { get; set; }
        public Dictionary<string, decimal> expectedDict1 { get; set; }
        public List<Expense> testRepo { get; set; }
        public IOptymizer optymizer { get; set; }
        public IExpenseRepository expenseRepository { get; set; }
        public ITableRepository tableRepository { get; set; }
        public ExpenseMaker expMaker { get; set; }


        [SetUp]
        public void Setup()
        {
            tableRepository = new MockTableRepository();
            //tableInfo = tableRepository.GetInformationAboutTable();

            expenseRepository = new MockExpenseRepository();
            //repo = expenseRepository.GetAllExpenses();

            expMaker = new ExpenseMaker();

            optymizer = new Optimizer();

            expectedDict1 = new Dictionary<string, decimal>() { 
                { "Igor_Adam", 4.20m }, { "Heniek_Adam", 4.20m }, 
                { "Adam_Igor", 2.05m }, { "Heniek_Igor", 2.05m }, 
                { "Adam_Heniek", 8.10m }, { "Igor_Heniek", 8.10m } };

            testRepo = new List<Expense>();
            //testRepo.Add(expMaker.CreateExpense(1, "Adam", 4.0m, new List<string>() { "Tomek", "Igor", "Heniek" }));
            testRepo.Add(expMaker.CreateExpense(1, "Adam", 4.0m, "Tomek,Igor,Heniek"));
            //testRepo.Add(expMaker.CreateExpense(1, "Tomek", 8.0m, new List<string>() { "Adam", "Igor", "Heniek" }));
            testRepo.Add(expMaker.CreateExpense(1, "Tomek", 8.0m, "Adam,Igor,Heniek"));
            //testRepo.Add(expMaker.CreateExpense(1, "Igor", 2.0m, new List<string>() { "Adam" }));
            testRepo.Add(expMaker.CreateExpense(1, "Igor", 2.0m, "Adam"));
            //testRepo.Add(expMaker.CreateExpense(1, "Heniek", 4.0m, new List<string>() { "Adam", "Tomek", "Igor" }));
            testRepo.Add(expMaker.CreateExpense(1, "Heniek", 4.0m, "Adam,Tomek,Igor"));

        }


        [Test]
        public void DictionaryTest_EverybodyInvolved()
        {
            //Arrange
            ICalculationMethod calculationMethod = new CalculationMethod();
            Calculation calculation = new Calculation(expenseRepository, tableRepository, calculationMethod, optymizer);

            //Act
            var dict = calculationMethod.CalculateMembersExpenses(calculation);
            var firstvalue = dict["Igor_Heniek"];

            //Assert
            Assert.IsNotNull(dict);
            Assert.AreEqual(expectedDict1.Count, dict.Count);
            Assert.Contains("Igor_Adam", dict.Keys);
            Assert.AreEqual(8.10m, firstvalue);
        }

        [Test]
        public void DictionaryTest_OnePersonInvolved()
        {
            //Arrange

            //var exp = expMaker.CreateExpense(1, "Adam", 12.60m, new List<string>() { "Igor" });
            var exp = expMaker.CreateExpense(1, "Adam", 12.60m, "Igor");
            var mockRepository = new Mock<IExpenseRepository>();
            mockRepository.Setup(x => x.GetAllExpenses()).Returns(new List<Expense>() { exp });

            ICalculationMethod calculationMethod = new CalculationMethod();
            Calculation calculation = new Calculation(mockRepository.Object, tableRepository, calculationMethod, optymizer);

            //Act
            var dict = calculationMethod.CalculateMembersExpenses(calculation);
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

            //Act
            var exp = expenseRepository.GetAllExpenses()[0];
            string name = exp.Name;
            List<string> membersInvolved = exp.NamesOfMembersInvolved.Split(',').ToList();

            string singleStringForDict = calculationMethod.CreateStringForDictionary(membersInvolved, name, 0);
            string expectedString = "Igor_Adam";

            //Assert
            Assert.AreEqual(expectedString, singleStringForDict);
        }
        [Test]
        public void DictionaryTest_Optimization_Simple()
        {
            //Arrange
            var simpledict = new Dictionary<string, decimal>() { { "Adam_Igor", 5.10m }, { "Igor_Adam", 3.05m } };
            CalculationMethod calculationMethod = new CalculationMethod();

            //Act
            var dict = calculationMethod.OptimizeDict(simpledict);

            var expecteddict = new Dictionary<string, decimal>() {
                { "Adam_Igor", 2.05m }};



            //Assert
            Assert.IsNotNull(dict);
            Assert.AreEqual(expecteddict.Count, dict.Count);
            Assert.Contains("Adam_Igor", dict.Keys);
            Assert.Contains(2.05m, dict.Values);
        }
        [Test]
        public void DictionaryTest_Optimization()
        {
            //Arrange
            ICalculationMethod calculationMethod = new CalculationMethod();
            Calculation calculation = new Calculation(expenseRepository, tableRepository, calculationMethod, optymizer);

            //Act
            var dict = calculationMethod.CalculateMembersExpenses(calculation);
            var optidict = calculationMethod.OptimizeDict(dict);

            var expecteddict = new Dictionary<string, decimal>() {
                { "Igor_Adam", 2.15m }, { "Adam_Heniek", 3.90m },
                { "Igor_Heniek", 6.05m } };
            var keylist = new List<string>() { "Igor_Adam", "Adam_Heniek", "Igor_Heniek" };
            var valuelist = new List<decimal>() { 2.15m, 3.90m, 6.05m };


            //Assert
            Assert.IsNotNull(optidict);
            Assert.AreEqual(expecteddict.Count, optidict.Count);
            Assert.Contains("Igor_Adam", optidict.Keys);
            Assert.AreEqual(keylist, optidict.Keys.ToList());
            Assert.AreEqual(valuelist, optidict.Values.ToList());
        }
        [Test]
        public void CalculateShareMethodTest()
        {
            //Arrange
            ICalculationMethod calculationMethod = new CalculationMethod();
            Calculation calculation = new Calculation(expenseRepository, tableRepository, calculationMethod, optymizer);

            //Act
            var resultdict = calculation.CalculateShare();

            var expecteddict = new Dictionary<string, decimal>() { { "Adam_Heniek", 1.75m }, { "Igor_Heniek", 8.2m } };
            var keylist = new List<string>() { "Adam_Heniek", "Igor_Heniek" };
            var valuelist = new List<decimal>() { 1.75m, 8.2m };

            //Assert
            Assert.IsNotNull(resultdict);
            Assert.AreEqual(expecteddict.Count, resultdict.Count);
            Assert.AreEqual(keylist, resultdict.Keys.ToList());
            Assert.AreEqual(valuelist, resultdict.Values.ToList());
        }
        [Test]
        public void CalculationsForTestRepo()
        {
            //Arrange
            var mockTestRepo = new Mock<IExpenseRepository>();
            mockTestRepo.Setup(x => x.GetAllExpenses()).Returns(testRepo);

            ICalculationMethod calculationMethod = new CalculationMethod();
            Calculation calculation = new Calculation(mockTestRepo.Object, tableRepository, calculationMethod, optymizer);

            //Act
            var resultdict = calculation.CalculateShare();

            var expecteddict = new Dictionary<string, decimal>() { { "Adam_Tomek", 1.0m }, { "Igor_Tomek", 3.0m } };
            var keylist = new List<string>() { "Adam_Tomek", "Igor_Tomek" };
            var valuelist = new List<decimal>() { 1.0m, 3.0m };

            //Assert
            Assert.IsNotNull(resultdict);
            Assert.AreEqual(expecteddict.Count, resultdict.Count);
            Assert.Contains("Adam_Tomek", resultdict.Keys);
            Assert.AreEqual(keylist, resultdict.Keys.ToList());
            Assert.AreEqual(valuelist, resultdict.Values.ToList());
        }

        [Test]
        public void CreatingOppositeKeyTest()
        {
            //Arrange
            CalculationMethod calculationMethod = new CalculationMethod();

            //Act
            var newstring = calculationMethod.MakingOppositeKey("Igor_Adam");

            //Assert
            Assert.AreEqual("Adam_Igor", newstring);
        }

        [Test]
        public void OptimizeDictMethodTest()
        {
            //Arrange
            IOptymizer optymizer = new Optimizer();
            var simpledict1 = new Dictionary<string, decimal>() { { "Adam_Tomek", 1.0m}, { "Igor_Tomek", 2.0m},
                {"Heniek_Tomek", 1.0m }, {"Igor_Heniek", 1.0m} };

            var expecteddict1 = new Dictionary<string, decimal>() { { "Adam_Tomek", 1.0m }, { "Igor_Tomek", 3.0m } };

            var simpledict2 = new Dictionary<string, decimal>() { { "Igor_Tomek", 2.0m}, { "Heniek_Tomek", 1.0m},
                {"Igor_Heniek", 1.0m }, {"Adam_Igor", 3.0m}, {"Adam_Tomek", 1.0m } };

            var expecteddict2 = new Dictionary<string, decimal>() { { "Adam_Tomek", 4.0m } };

            var simpledict3 = new Dictionary<string, decimal>() { { "Igor_Adam", 2.15m}, { "Adam_Heniek", 3.9m},
                {"Igor_Heniek", 6.05m }};

            var expecteddict3 = new Dictionary<string, decimal>() { { "Adam_Heniek", 1.75m}, { "Igor_Heniek", 8.2m}};
            
            //Act
            var dict1 = optymizer.OptimizeDict(simpledict1);
            var dict2 = optymizer.OptimizeDict(simpledict2);
            var dict3 = optymizer.OptimizeDict(simpledict3);

            //Assert
            Assert.AreEqual(expecteddict1, dict1);
            Assert.AreEqual(expecteddict1.Keys, dict1.Keys);
            Assert.AreEqual(expecteddict1.Values, dict1.Values);

            Assert.AreEqual(expecteddict2, dict2);
            Assert.AreEqual(expecteddict2.Keys, dict2.Keys);
            Assert.AreEqual(expecteddict2.Values, dict2.Values);

            Assert.AreEqual(expecteddict3, dict3);
            Assert.AreEqual(expecteddict3.Keys, dict3.Keys);
            Assert.AreEqual(expecteddict3.Values, dict3.Values);
        }
    }
}
