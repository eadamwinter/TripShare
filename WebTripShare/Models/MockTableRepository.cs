using System;
using System.Collections.Generic;
using System.Text;
using WebTripShare.Models;
using System.Linq;

namespace TripShare
{
    public class MockTableRepository : ITableRepository
    {
        public void AddNewTable(NewTableViewModel newTableViewModel)
        {
            throw new NotImplementedException();
        }

        public TableInfo GetTableById(byte id)
        {
            MockMembersRepository mockMembersRepository = new MockMembersRepository();


            TableInfo tableInfo = new TableInfo();
            tableInfo.TableInfoId = 1;
            tableInfo.TableName = "GorskieMalrze";
            tableInfo.Members = mockMembersRepository.GetAllMembers(id).ToList();
            return tableInfo;
        }
        public List<TableInfo> GetTables()
        {
            throw new NotImplementedException();
        }
    }
}
