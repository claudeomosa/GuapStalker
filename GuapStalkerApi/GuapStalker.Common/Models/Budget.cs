using System.Data;

namespace GuapStalker.Common.Models;

/// <summary>
/// Budget Model
/// </summary>
/// <param name="user"></param>
public class Budget(User user)
{
    public Ulid Id { get; set; }
    public string Category { get; set; } = string.Empty;
    public decimal Limit { get; set; }
    public User User { get; init; } = user ?? throw new NoNullAllowedException("Budget requires an associated user");
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}