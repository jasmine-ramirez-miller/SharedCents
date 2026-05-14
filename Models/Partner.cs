using System.ComponentModel.DataAnnotations;

namespace SharedCents.Models
{
    // Represents a user/partner in the SharedCents application
    public class Partner
    {
        // Primary Key
        public int PartnerId { get; set; }

        // Partner's first name
        [Required]
        public string FirstName { get; set; }

        // Partner's email address
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Monthly income amount
        [Range(0, 1000000)]
        public decimal MonthlyIncome { get; set; }

        // Navigation Property
        // One Partner can have many Expenses
        public List<Expense> Expenses { get; set; } = new();
    }
}