using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Models
{
    public class TableViewModel
    {
        public List<string> TableResults { get; set; }
        public TableInfo tableInfo { get; set; }
        public TableViewModel(List<string> tableResults, TableInfo tableInfo)
        {
            TableResults = tableResults;
            this.tableInfo = tableInfo;
        }
    }
}
