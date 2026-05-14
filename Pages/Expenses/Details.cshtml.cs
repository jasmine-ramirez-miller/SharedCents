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
    public class DetailsModel : PageModel
    {
        private readonly SharedCents.Data.AppDbContext _context;

        public DetailsModel(SharedCents.Data.AppDbContext context)
        {
            _context = context;
        }

        public Expense Expense { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses.FirstOrDefaultAsync(m => m.ExpenseId == id);

            if (expense is not null)
            {
                Expense = expense;

                return Page();
            }

            return NotFound();
        }
    }
}
