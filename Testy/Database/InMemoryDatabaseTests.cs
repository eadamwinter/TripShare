using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using TripShare;
using WebTripShare.Models;
using System.Linq;

namespace Testy.Database
{
    class InMemoryDatabaseTests
    {

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AddNewTable_InsertTableToEmptyDatabase()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("DatabaseForTesting").Options;

            using (var context = new AppDbContext(options))
            {
                //Arrange
                TableRepository tableRepository = new TableRepository(context);
                MembersRepository memberRepository = new MembersRepository(context);

                NewTableViewModel model = new NewTableViewModel();
                model.TableName = "NewGroup";
                model.NumberOfMembers = 3;
                model.Names = new HashSet<string>() { "Adam", "Wiktor", "Piotr" };

                //Act
                tableRepository.AddNewTable(model);

                var data = tableRepository.GetTables();

                var members = memberRepository.GetAllMembers(data[0].TableInfoId).ToList();
                //Assert
                Assert.AreEqual(1, data.Count);
                Assert.IsNotNull(data);

                Assert.AreEqual("NewGroup", data[0].TableName);
                Assert.AreEqual(1, data[0].TableInfoId);

                Assert.AreEqual(3, members.Count);
                Assert.AreEqual("Adam", members[0].Name);


            }
        }

        [Test]
        public void AddNewTable_InsertTableToDatabaseWithData()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("DatabaseForTesting2").Options;

            using (var context = new AppDbContext(options))
            {
                //Arrange
                TableRepository tableRepository = new TableRepository(context);
                MembersRepository memberRepository = new MembersRepository(context);

                context.Tables.Add(new TableInfo()
                {
                    TableInfoId = 1,
                    TableName = "NewGroup",
                    Members = new List<MembersInfo>() { 
                        new MembersInfo { Name = "Adam", MembersInfoId = 1, TableNumber = 1 },
                        new MembersInfo { Name = "Wiktor", MembersInfoId =2, TableNumber = 1 }
                    }
                });
                context.Tables.Add(new TableInfo()
                {
                    TableInfoId = 3,
                    TableName = "NewGroup",
                    Members = new List<MembersInfo>() {
                        new MembersInfo { Name = "Adam", MembersInfoId = 5, TableNumber = 3 },
                        new MembersInfo { Name = "Wiktor", MembersInfoId = 6, TableNumber = 3 }
                    }
                });
                context.SaveChanges();

                NewTableViewModel model = new NewTableViewModel();
                model.TableName = "Misiaki";
                model.NumberOfMembers = 3;
                model.Names = new HashSet<string>() { "Heniek", "Olgierd", "Piotr" };

                //Act
                tableRepository.AddNewTable(model);

                var data = tableRepository.GetTables();
                var table = data.First(a => a.TableName == "Misiaki");

                var members = memberRepository.GetAllMembers(table.TableInfoId).ToList();
                var heniek = members.First(a => a.Name == "Heniek");
                //Assert
                Assert.AreEqual(3, data.Count);
                Assert.IsNotNull(data);

                Assert.AreEqual(4, table.TableInfoId);
                Assert.AreEqual("Misiaki", table.TableName);
                Assert.AreEqual(3, table.Members.Count);

                Assert.AreEqual(3, members.Count);

                Assert.AreEqual("Heniek", heniek.Name);
                Assert.AreEqual(7, heniek.MembersInfoId);
                Assert.AreEqual(4, heniek.TableNumber);
            }
        }
    }
}
