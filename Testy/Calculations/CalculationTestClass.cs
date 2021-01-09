using NUnit.Framework;
using TripShare;

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
            byte numberOfMembers = 2;
            var mockData = new MockExpenseRepository();
            var repo = mockData.GetAllExpenses();
            Calculation calculation = new Calculation(repo, numberOfMembers);

            //Act
            var result = calculation.CalculateEqualExpense();

            //Assert
            Assert.AreEqual(14.3, result);
            
        }
    }
}
