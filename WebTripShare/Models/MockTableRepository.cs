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
            tableInfo.TableNumber = 1;
            tableInfo.TableName = "GorskieMalrze";
            tableInfo.NumberOfMembers = 3;
            tableInfo.NamesOfMembers = new List<string>() { "Adam", "Igor", "Heniek" };
            return tableInfo;
        }
    }
}
