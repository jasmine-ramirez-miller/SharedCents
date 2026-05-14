using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SharedCents.Models
{
    // Represents an expense record in the SharedCents application
    public class Expense
    {
        // Primary key
        public int ExpenseId { get; set; }

        // Name of the expense
        [Required]
        [StringLength(75)]
        public string ExpenseName { get; set; }

        // Expense category
        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        // Dollar amount of the expense
        [Range(0.01, 100000)]
        public decimal Amount { get; set; }

        // Due date for the expense
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        // Indicates whether the expense has been paid
        public bool IsPaid { get; set; }

        // Indicates whether the expense is shared between partners
        public bool IsShared { get; set; }

        // Foreign key connected to Partner
        public int PartnerId { get; set; }

        // Navigation property
        // Each expense belongs to one partner
        [ValidateNever]
        public Partner Partner { get; set; }
    }
}