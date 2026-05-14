using Microsoft.EntityFrameworkCore;
using SharedCents.Models;

namespace SharedCents.Data
{
    // Connects the application models to the database using Entity Framework Core
    public class AppDbContext : DbContext
    {
        // Passes database configuration options into the DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Creates a Partners table in the database
        public DbSet<Partner> Partners { get; set; }

        // Creates an Expenses table in the database
        public DbSet<Expense> Expenses { get; set; }

        // Adds starting/sample data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed partner data
            modelBuilder.Entity<Partner>().HasData(
                new Partner
                {
                    PartnerId = 1,
                    FirstName = "Jasmine",
                    Email = "jasmine@email.com",
                    MonthlyIncome = 3200
                },
                new Partner
                {
                    PartnerId = 2,
                    FirstName = "Adrian",
                    Email = "Adrian@email.com",
                    MonthlyIncome = 3500
                }
            );

            // Seed expense data
            // This gives the app at least 25 expense records for paging, searching, and sorting.
            modelBuilder.Entity<Expense>().HasData(
                new Expense { ExpenseId = 1, ExpenseName = "Rent", Category = "Housing", Amount = 1000, DueDate = new DateTime(2026, 5, 15), IsPaid = false, IsShared = true, PartnerId = 1 },
                new Expense { ExpenseId = 2, ExpenseName = "Electric Bill", Category = "Utilities", Amount = 145, DueDate = new DateTime(2026, 5, 18), IsPaid = false, IsShared = true, PartnerId = 2 },
                new Expense { ExpenseId = 3, ExpenseName = "Water Bill", Category = "Utilities", Amount = 72, DueDate = new DateTime(2026, 5, 20), IsPaid = false, IsShared = true, PartnerId = 1 },
                new Expense { ExpenseId = 4, ExpenseName = "Internet", Category = "Utilities", Amount = 85, DueDate = new DateTime(2026, 5, 22), IsPaid = true, IsShared = true, PartnerId = 2 },
                new Expense { ExpenseId = 5, ExpenseName = "Groceries", Category = "Food", Amount = 210, DueDate = new DateTime(2026, 5, 23), IsPaid = true, IsShared = true, PartnerId = 1 },
                new Expense { ExpenseId = 6, ExpenseName = "Car Insurance", Category = "Transportation", Amount = 168, DueDate = new DateTime(2026, 5, 25), IsPaid = false, IsShared = false, PartnerId = 1 },
                new Expense { ExpenseId = 7, ExpenseName = "Phone Bill", Category = "Utilities", Amount = 95, DueDate = new DateTime(2026, 5, 26), IsPaid = false, IsShared = false, PartnerId = 2 },
                new Expense { ExpenseId = 8, ExpenseName = "Streaming Services", Category = "Entertainment", Amount = 48, DueDate = new DateTime(2026, 5, 28), IsPaid = true, IsShared = true, PartnerId = 1 },
                new Expense { ExpenseId = 9, ExpenseName = "Gas", Category = "Transportation", Amount = 120, DueDate = new DateTime(2026, 5, 29), IsPaid = false, IsShared = false, PartnerId = 2 },
                new Expense { ExpenseId = 10, ExpenseName = "Dining Out", Category = "Food", Amount = 90, DueDate = new DateTime(2026, 5, 30), IsPaid = true, IsShared = true, PartnerId = 1 },

                new Expense { ExpenseId = 11, ExpenseName = "Rent", Category = "Housing", Amount = 1000, DueDate = new DateTime(2026, 6, 15), IsPaid = false, IsShared = true, PartnerId = 2 },
                new Expense { ExpenseId = 12, ExpenseName = "Electric Bill", Category = "Utilities", Amount = 138, DueDate = new DateTime(2026, 6, 18), IsPaid = false, IsShared = true, PartnerId = 1 },
                new Expense { ExpenseId = 13, ExpenseName = "Water Bill", Category = "Utilities", Amount = 69, DueDate = new DateTime(2026, 6, 20), IsPaid = false, IsShared = true, PartnerId = 2 },
                new Expense { ExpenseId = 14, ExpenseName = "Internet", Category = "Utilities", Amount = 85, DueDate = new DateTime(2026, 6, 22), IsPaid = false, IsShared = true, PartnerId = 1 },
                new Expense { ExpenseId = 15, ExpenseName = "Groceries", Category = "Food", Amount = 235, DueDate = new DateTime(2026, 6, 23), IsPaid = false, IsShared = true, PartnerId = 2 },
                new Expense { ExpenseId = 16, ExpenseName = "Car Payment", Category = "Transportation", Amount = 420, DueDate = new DateTime(2026, 6, 24), IsPaid = false, IsShared = false, PartnerId = 1 },
                new Expense { ExpenseId = 17, ExpenseName = "Car Insurance", Category = "Transportation", Amount = 168, DueDate = new DateTime(2026, 6, 25), IsPaid = false, IsShared = false, PartnerId = 2 },
                new Expense { ExpenseId = 18, ExpenseName = "Phone Bill", Category = "Utilities", Amount = 95, DueDate = new DateTime(2026, 6, 26), IsPaid = false, IsShared = false, PartnerId = 1 },
                new Expense { ExpenseId = 19, ExpenseName = "Household Supplies", Category = "Household", Amount = 76, DueDate = new DateTime(2026, 6, 27), IsPaid = false, IsShared = true, PartnerId = 2 },
                new Expense { ExpenseId = 20, ExpenseName = "Streaming Services", Category = "Entertainment", Amount = 48, DueDate = new DateTime(2026, 6, 28), IsPaid = false, IsShared = true, PartnerId = 1 },

                new Expense { ExpenseId = 21, ExpenseName = "Gas", Category = "Transportation", Amount = 115, DueDate = new DateTime(2026, 6, 29), IsPaid = false, IsShared = false, PartnerId = 2 },
                new Expense { ExpenseId = 22, ExpenseName = "Dining Out", Category = "Food", Amount = 105, DueDate = new DateTime(2026, 6, 30), IsPaid = false, IsShared = true, PartnerId = 1 },
                new Expense { ExpenseId = 23, ExpenseName = "Pet Supplies", Category = "Pets", Amount = 64, DueDate = new DateTime(2026, 7, 2), IsPaid = false, IsShared = true, PartnerId = 2 },
                new Expense { ExpenseId = 24, ExpenseName = "Medical Copay", Category = "Health", Amount = 40, DueDate = new DateTime(2026, 7, 4), IsPaid = false, IsShared = false, PartnerId = 1 },
                new Expense { ExpenseId = 25, ExpenseName = "Savings Transfer", Category = "Savings", Amount = 250, DueDate = new DateTime(2026, 7, 5), IsPaid = false, IsShared = true, PartnerId = 2 }
            );
        }
    }
}