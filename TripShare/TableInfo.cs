using System.Collections.Generic;

namespace TripShare
{
    public class TableInfo
    {
        public byte TableInfoId { get; set; }
        public string TableName { get; set; }
        public List<MembersInfo> Members { get; set; }
    }
}
