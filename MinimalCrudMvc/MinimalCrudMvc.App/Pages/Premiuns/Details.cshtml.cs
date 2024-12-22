using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinimalCrudMvc.App.Data;
using MinimalCrudMvc.App.Models;

namespace MinimalCrudMvc.App.Pages.Premiuns
{
    public class DetailsModel : PageModel
    {
        private readonly MinimalCrudMvc.App.Data.ApplicationDbContext _context;

        public DetailsModel(MinimalCrudMvc.App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Premium Premium { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premia.FirstOrDefaultAsync(m => m.Id == id);

            if (premium is not null)
            {
                Premium = premium;

                return Page();
            }

            return NotFound();
        }
    }
}
