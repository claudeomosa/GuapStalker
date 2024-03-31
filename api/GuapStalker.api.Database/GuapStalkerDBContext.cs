using database.Models;
using Microsoft.EntityFrameworkCore;

namespace database
{
    public class GuapStalkerDBContext: DbContext
    {
        public GuapStalkerDBContext(DbContextOptions<GuapStalkerDBContext> options) : base(options)
        {
        }

        public DbSet<Investment> Investments { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Budget> Budgets { get; set; } = null!;
    }
}
