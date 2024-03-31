namespace database.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public enum Type
        {
            Income,
            Expense
        }
        public string? Description { get; set; } = null;
        public DateTime Date { get; set; }
        public Category Category { get; set; } = null!;
        public User User { get; set; } = null!;
        public Transaction() 
        { 
            Date = DateTime.Now;
        }
    }
}
