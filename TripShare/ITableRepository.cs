using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface ITableRepository
    {
        List<TableInfo> GetTables();
        TableInfo GetTableById(byte id);
        void DeleteTable(byte id);
        void AddNewTable(NewTableViewModel newTableViewModel);
    }
}
