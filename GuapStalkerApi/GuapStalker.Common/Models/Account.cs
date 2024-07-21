using System.Data;

namespace GuapStalker.Common.Models;

public class Account(User owner)
{
    public int Id { get; set; }
    public AccountType Type { get; set; }
    public decimal Balance { get; set; }
    public User Owner { get; init; } = owner ?? throw new NoNullAllowedException("Account requires an associated Account Owner");
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}

public enum AccountType
{
    Checking = 0,
    Saving = 1
}