using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TripShare;
using WebTripShare.Models;

namespace Testy.Expenses
{
    public class ExpensesTestClass
    {
        private Mock<IExpenseRepository> _exprepo;

        [SetUp]
        public void Setup()
        {
            _exprepo = new Mock<IExpenseRepository>();
        }

        [Test]
        public void CreatingNewExpense()
        {
            //Arrange
            Expense expense = new Expense();
            expense.TableNumber = 1;
            expense.Name = "Adam";
            expense.Amount = 15.40m;
            expense.TimeOfExpense = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            expense.NamesOfMembersInvolved = "Igor,Tomek";
            expense.NumberOfMembersInvolved = 2;

            //Act

            //Assert
            Assert.AreEqual(1, expense.TableNumber);
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
            Assert.AreEqual(1, expense1.TableNumber);
            Assert.AreEqual("Igor", expense2.Name);
        }

        //[Test]
        //public void AddingNewExpense()
        //{
        //    //Arrange

        //    Expense expectedExpense = new Expense();
        //    expectedExpense.Name = "Adam";
        //    expectedExpense.Amount = 25.00m;

        //    Expense savedExpense = null;

        //    _exprepo.Setup(e => e.AddNewExpense(It.IsAny<Expense>())).Callback<Expense>(expectedExpense =>
        //    {
        //        savedExpense = expectedExpense;
        //    });

        //    //Act

        //    IExpenseRepository expenseRepository = new MockExpenseRepository(_exprepo.Object);
        //    expenseRepository.AddNewExpense(expectedExpense);

        //    //Assert
        //    Assert.NotNull(savedExpense);
        //    Assert.AreEqual(expectedExpense.Name, savedExpense.Name);
        //    Assert.AreEqual(expectedExpense.Amount, savedExpense.Amount);
        //}

        [Test]
        public void ExpenseMaker_CreateExpenseTest()
        {
            //Arrange
            byte TableNumber = 1;
            string Name = "Adam";
            decimal Amount = 24.99m;
            string MembersInvolved = "Igor,Tomek";


            //Act
            Expense expense = ExpenseMaker.CreateExpense(TableNumber, Name, Amount, MembersInvolved);

            //Assert
            Assert.IsNotNull(expense);
            Assert.AreEqual(Name, expense.Name);
            Assert.AreEqual(Amount, expense.Amount);
            Assert.AreEqual("No comment added.", expense.Comment);
            Assert.AreEqual(MembersInvolved, expense.NamesOfMembersInvolved);
            Assert.AreEqual(2, expense.NumberOfMembersInvolved);
        }
    }
}