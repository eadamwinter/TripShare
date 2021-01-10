using NUnit.Framework;
using TripShare;

namespace Testy.Table
{
    class TableTestClass
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GettingInfoAboutTables()
        {
            //Arrange
            ITableRepository tableRepository = new MockTableRepository();
            TableInfo tableInfo = tableRepository.GetInformationAboutTable();

            //Act

            //Assert
            Assert.IsNotNull(tableInfo);
            Assert.AreEqual(3, tableInfo.NumberOfMembers);

        }
    }
}
