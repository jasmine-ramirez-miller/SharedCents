using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SharedCents.Data;
using SharedCents.Models;

namespace SharedCents.Pages.Partners
{
    public class DeleteModel : PageModel
    {
        private readonly SharedCents.Data.AppDbContext _context;

        public DeleteModel(SharedCents.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Partner Partner { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FirstOrDefaultAsync(m => m.PartnerId == id);

            if (partner is not null)
            {
                Partner = partner;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FindAsync(id);
            if (partner != null)
            {
                Partner = partner;
                _context.Partners.Remove(Partner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
