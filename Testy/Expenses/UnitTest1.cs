using NUnit.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TripShare;

namespace Testy
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatingNewExpense()
        {
            //Arrange
            byte NumerTabeli = 1;
            string imie = "Adam";
            decimal wydatek = 15.40m;
            List<string> mocklista = new List<string>();

            //Act
            Expense expense = new Expense(NumerTabeli, imie, wydatek, mocklista);

            //Assert
            Assert.AreEqual(1, expense.IdTable);
            Assert.AreEqual("Adam", expense.Name);
            Assert.AreEqual(15.4, expense.Amount);

            Assert.IsNotNull(expense.TimeOfExpense);
            Assert.IsTrue(Regex.IsMatch(expense.TimeOfExpense, @"\d{2}-\d{2}-\d{4} \d{2}:\d{2}:\d{2}"));
        }

        [Test]
        public void GetingAllExpensesFromRepository()
        {
            //Arrange
            IExpenseRepository expenseRepository = new MockExpenseRepository();

            //Act
            var expenses = expenseRepository.GetAllExpenses();
            var expense1 = expenses[0];
            var expense2 = expenses[1];

            //Assert
            Assert.AreEqual(1, expense1.IdTable);
            Assert.AreEqual("Igor", expense2.Name);
        }
    }
}