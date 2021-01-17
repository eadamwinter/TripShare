using System;
using System.Collections.Generic;
using System.Text;
using WebTripShare.Models;
using System.Linq;

namespace TripShare
{
    public class MockTableRepository : ITableRepository
    {
        public TableInfo GetInformationAboutTable()
        {
            MockMembersRepository mockMembersRepository = new MockMembersRepository();


            TableInfo tableInfo = new TableInfo();
            tableInfo.TableInfoId = 1;
            tableInfo.TableName = "GorskieMalrze";
            tableInfo.Members = mockMembersRepository.GetAllMembers().ToList();
            return tableInfo;
        }
    }
}
