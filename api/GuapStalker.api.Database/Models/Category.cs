namespace database.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public enum Type
        {
            Income,
            Expense
        }
    }
}
