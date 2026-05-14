using System.ComponentModel.DataAnnotations;

namespace SharedCents.Models
{
    // Represents a user/partner in the SharedCents application
    public class Partner
    {
        // Primary key
        public int PartnerId { get; set; }

        // Partner's first name
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        // Partner's email address
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        // Monthly income amount
        [Range(0, 100000)]
        public decimal MonthlyIncome { get; set; }

        // Navigation property
        // One partner can have many expenses
        public List<Expense> Expenses { get; set; } = new();
    }
}