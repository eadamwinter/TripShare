using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class MockTableRepository : ITableRepository
    {
        public TableInfo GetInformationAboutTable()
        {
            TableInfo tableInfo = new TableInfo();
            tableInfo.TableName = "GorskieMalrze";
            tableInfo.NumberOfMembers = 2;
            tableInfo.NamesOfMemebers = new List<string>() { "Adam", "Igor" };
            return tableInfo;
        }
    }
}
