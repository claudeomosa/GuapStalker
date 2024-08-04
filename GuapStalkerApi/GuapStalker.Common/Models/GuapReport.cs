using System.Data;

namespace GuapStalker.Common.Models;

/// <summary>
/// A report model
/// </summary>
/// <param name="user"></param>
public class GuapReport(User user)
{
    public Ulid Id { get; set; }
    public DateTime ReportDate { get; set; }
    public decimal TotalIncome { get; set; }
    public decimal TotalExpense { get; set; }
    public decimal NetSavings { get; set; }
    public User User { get; init; } = user ?? throw new NoNullAllowedException("Report should have an associated User oit belongs to");
}