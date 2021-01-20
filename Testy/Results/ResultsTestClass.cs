using NUnit.Framework;
using System.Collections.Generic;
using TripShare;

namespace Testy.Results
{
    class ResultsTestClass
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GettingCalculatedData()
        {
            //Arrange
            IResultMaker resultMaker = new ResultMaker();

            //Act
            var simpledict = new Dictionary<string, decimal>() { { "Adam_Igor", 1.10m }, { "Heniek_Tomek", 3.20m } };

            var result = resultMaker.PrepareResult(simpledict);

            //Assert
            Assert.IsNotNull(result);
            
            Assert.Contains("Adam should return Igor 1,10zł.", result);
            Assert.Contains("Heniek should return Tomek 3,20zł.", result);
        }
    }
}
