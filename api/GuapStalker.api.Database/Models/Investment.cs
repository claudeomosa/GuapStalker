namespace database.Models
{
    public class Investment
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsRecurring { get; set; }
        public decimal? RecurringAmount { get; set; }
        public int RecurringInterval { get; set; }
        public enum RecurringFrequency
    { 
            Daily, 
            Weekly, 
            Monthly, 
            Yearly 
        }
        public User User { get; set; } = null!;

        public Investment(RecurringFrequency recurringFrequency)
        {
            if (IsRecurring)
            {
                RecurringAmount = Amount;
                RecurringInterval = 1;
            }

            if (recurringFrequency == RecurringFrequency.Daily)
            {
                RecurringInterval = 1;
            }
            else if (recurringFrequency == RecurringFrequency.Weekly)
            {
                RecurringInterval = 7;
            }
            else if (recurringFrequency == RecurringFrequency.Monthly)
            {
                RecurringInterval = 30;
            }
            else if (recurringFrequency == RecurringFrequency.Yearly)
            {
                RecurringInterval = 365;
            }
        }
    }
}
