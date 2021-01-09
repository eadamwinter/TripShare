using NUnit.Framework;
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
            double wydatek = 15.40;


            //Act
            Expense expense = new Expense(NumerTabeli, imie, wydatek);

            //Assert
            Assert.AreEqual(1, expense.idTabeli);
            Assert.AreEqual("Adam", expense.imie);
            Assert.AreEqual(15.4, expense.wydatek);
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
            Assert.AreEqual(1, expense1.idTabeli);
            Assert.AreEqual("Igor", expense2.imie);
        }
    }
}