using System.ComponentModel.DataAnnotations;

namespace SharedCents.Models
{
    // Represents an expense record in the SharedCents application
    public class Expense
    {
        // Primary Key
        public int ExpenseId { get; set; }

        // Name of the expense
        [Required]
        public string ExpenseName { get; set; }

        // Expense category (Rent, Utilities, Food, etc.)
        [Required]
        public string Category { get; set; }

        // Dollar amount of the expense
        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }

        // Due date for the expense
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        // Indicates whether the expense has been paid
        public bool IsPaid { get; set; }

        // Indicates whether the expense is shared between partners
        public bool IsShared { get; set; }

        // Foreign Key connected to Partner
        public int PartnerId { get; set; }

        // Navigation Property
        // Each Expense belongs to one Partner
        public Partner Partner { get; set; }
    }
}