using System.Data;

namespace GuapStalker.Common.Models;

/// <summary>
/// A saving goal model
/// </summary>
/// <param name="user"></param>
public class SavingsGoal(User user)
{
    public Ulid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal TargetAmount { get; set; }
    public decimal CurrentAmount { get; set; }
    public DateTime TargetDate { get; set; }
    public User User { get; init; } = user ?? throw new NoNullAllowedException("A saving goal requires an associated User");
}