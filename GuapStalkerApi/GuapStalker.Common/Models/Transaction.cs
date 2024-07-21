using System.Data;

namespace GuapStalker.Common.Models;

public class Transaction(Account account)
{
    public int Id { get; set; }
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