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


        public static Expense CreateExpense(byte tableNumber, string name, decimal amount, string membersInvolved, string comment="No comment added.")
        {
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
    }
}
