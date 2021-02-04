using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TripShare
{
    public class ExpenseMaker
    {
        public byte TableNumber { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string MembersInvolved { get; set; }
        public string Comment { get; set; }


        public static Expense CreateExpense(byte tableNumber, string name, decimal amount, IEnumerable<string> membersInv, string comment="No comment added.")
        {
            string membersInvolved = MakeMembers(name, membersInv);

            Expense expense = new Expense();

            expense.TableNumber = tableNumber;
            expense.Name = name;
            expense.Amount = amount;
            expense.TimeOfExpense = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            expense.NamesOfMembersInvolved = membersInvolved;
            expense.NumberOfMembersInvolved = (byte)membersInvolved.Split(',').ToList().Count;
            expense.Comment = comment;

            return expense;
        }

        public static string MakeMembers(string name, IEnumerable<string> membersInvolved)
        {
            StringBuilder Members = new StringBuilder();
            foreach(string member in membersInvolved)
            {
                if(member!=name)
                {
                    Members.Append(member);
                    Members.Append(",");
                }
            }
            if(Members.Length>0) { Members.Length--; }
            return Members.ToString();
        }

    }
}
