using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class TableInfo
    {
        public string TableName { get; set; }
        public byte NumberOfMembers { get; set; }
        public List<string> NamesOfMemebers { get; set; }
    }
}
