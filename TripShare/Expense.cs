namespace TripShare
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public byte TableNumber { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string TimeOfExpense { get; set; }
        public byte NumberOfMembersInvolved { get; set; }
        public string NamesOfMembersInvolved { get; set; }
        public string Comment { get; set; }
    }
}
