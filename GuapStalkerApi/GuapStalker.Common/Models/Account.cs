using System.Data;

namespace GuapStalker.Common.Models;

/// <summary>
/// This is the Account Model
/// An Account must belong to at least one user ... maybe different approach for joint accounts
/// </summary>
/// <param name="owner">
/// Owner of the account
/// </param>
public class Account(User owner)
{
    public Ulid Id { get; set; }
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