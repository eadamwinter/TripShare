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
            TableInfo tableInfo = tableRepository.GetTableById(1);

            //Act

            //Assert
            Assert.IsNotNull(tableInfo);
            Assert.AreEqual(1, tableInfo.TableInfoId);
            Assert.AreEqual("GorskieMalrze", tableInfo.TableName);
            Assert.AreEqual(4, tableInfo.Members.Count);

        }
    }
}
