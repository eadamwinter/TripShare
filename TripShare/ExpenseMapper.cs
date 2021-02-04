using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class ExpenseMapper
    {
        public byte TableNumber { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public IEnumerable<string> MembersInvolved { get; set; }
        public string Comment { get; set; }
    }
}
