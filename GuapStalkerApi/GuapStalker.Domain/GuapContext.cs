using GuapStalker.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace GuapStalker.Domain;

public class GuapContext: DbContext
{
    public GuapContext(DbContextOptions<GuapContext> opts): base(opts) {}
    
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<GuapReport> GuapReports { get; set; }
    public DbSet<SavingsGoal> SavingsGoals { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Budget> Budgets { get; set; }
    
}