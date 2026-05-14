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
    public class DetailsModel : PageModel
    {
        private readonly SharedCents.Data.AppDbContext _context;

        public DetailsModel(SharedCents.Data.AppDbContext context)
        {
            _context = context;
        }

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
    }
}
