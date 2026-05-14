using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SharedCents.Data;
using SharedCents.Models;

namespace SharedCents.Pages.Expenses
{
    public class IndexModel : PageModel
    {
        private readonly SharedCents.Data.AppDbContext _context;

        public IndexModel(SharedCents.Data.AppDbContext context)
        {
            _context = context;
        }

        // Stores the expense records displayed on the page
        public IList<Expense> Expense { get; set; } = default!;

        // Stores the current search text
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        // Stores the current sort order
        public string CurrentSort { get; set; }

        // Tracks the current page number
        public int CurrentPage { get; set; } = 1;

        // Total number of pages
        public int TotalPages { get; set; }

        public async Task OnGetAsync(string sortOrder, int pageNumber = 1)
        {
            // Save the current sort order
            CurrentSort = sortOrder;

            // Start building the expense query
            var expenses = from e in _context.Expenses.Include(e => e.Partner)
                           select e;

            // Search functionality
            if (!string.IsNullOrEmpty(SearchString))
            {
                expenses = expenses.Where(e =>
                    e.ExpenseName.Contains(SearchString) ||
                    e.Category.Contains(SearchString));
            }

            // Sorting functionality
            switch (sortOrder)
            {
                case "name_desc":
                    expenses = expenses.OrderByDescending(e => e.ExpenseName);
                    break;

                case "amount":
                    expenses = expenses.OrderBy(e => e.Amount);
                    break;

                case "amount_desc":
                    expenses = expenses.OrderByDescending(e => e.Amount);
                    break;

                default:
                    expenses = expenses.OrderBy(e => e.ExpenseName);
                    break;
                
                case "category":
                    expenses = expenses.OrderBy(e => e.Category);
                    break;

                case "category_desc":
                    expenses = expenses.OrderByDescending(e => e.Category);
                    break;
            }

            // Pagination setup
            int pageSize = 10;

            CurrentPage = pageNumber;

            TotalPages = (int)Math.Ceiling(await expenses.CountAsync() / (double)pageSize);

            // Retrieves only the records needed for the current page
            Expense = await expenses
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}