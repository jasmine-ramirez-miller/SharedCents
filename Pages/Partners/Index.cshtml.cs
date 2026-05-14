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
    public class IndexModel : PageModel
    {
        private readonly SharedCents.Data.AppDbContext _context;

        public IndexModel(SharedCents.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Partner> Partner { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Partner = await _context.Partners.ToListAsync();
        }
    }
}
