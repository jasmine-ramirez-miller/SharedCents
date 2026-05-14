using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SharedCents.Data;
using SharedCents.Models;

namespace SharedCents.Pages.Expenses
{
    public class CreateModel : PageModel
    {
        private readonly SharedCents.Data.AppDbContext _context;

        public CreateModel(SharedCents.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PartnerId"] = new SelectList(_context.Partners, "PartnerId", "FirstName");
            return Page();
        }

        [BindProperty]
        public Expense Expense { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Expenses.Add(Expense);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
