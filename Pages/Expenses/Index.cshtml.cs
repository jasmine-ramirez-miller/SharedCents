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

        public IList<Expense> Expense { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Expense = await _context.Expenses
                .Include(e => e.Partner).ToListAsync();
        }
    }
}
