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
    public class DeleteModel : PageModel
    {
        private readonly MinimalCrudMvc.App.Data.ApplicationDbContext _context;

        public DeleteModel(MinimalCrudMvc.App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premia.FindAsync(id);
            if (premium != null)
            {
                Premium = premium;
                _context.Premia.Remove(Premium);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
