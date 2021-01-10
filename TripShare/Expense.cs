using System;
using System.Collections.Generic;

namespace TripShare
{
    public class Expense
    {
        public byte IdTable { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string TimeOfExpense { get; set; }
        public byte NumberOfMembersInvolved { get; set; }
        public List<string> NamesOfMembersInvolved { get; set; }

        public Expense(byte idTabeli, string name, decimal amount, List<string> membersInvolved)
        {
            this.IdTable = idTabeli;
            this.Name = name;
            this.Amount = amount;
            this.TimeOfExpense = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            //narazie wszyscy będą zamieszani
            this.NamesOfMembersInvolved = membersInvolved;
            this.NumberOfMembersInvolved = (byte)membersInvolved.Count;
        }
    }
}
