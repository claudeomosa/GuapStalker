using System.Data;

namespace GuapStalker.Common.Models;

/// <summary>
/// Transaction model
/// </summary>
/// <param name="account"></param>
public class Transaction(Account account)
{
    public Ulid Id { get; set; }
    public string Description { get; set; } = "";
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public Account Account { get; init; } = account ?? throw new NoNullAllowedException("Transaction requires an associated Account!");
    public TransactionType Type { get; set; }
}

public enum TransactionType
{
    Income = 0,
    Expense = 1
}