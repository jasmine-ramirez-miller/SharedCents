using Microsoft.EntityFrameworkCore;
using SharedCents.Models;

namespace SharedCents.Data
{
    // Connects the application models to the database using Entity Framework Core
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Creates a Partners table in the database
        public DbSet<Partner> Partners { get; set; }

        // Creates an Expenses table in the database
        public DbSet<Expense> Expenses { get; set; }
    }
}