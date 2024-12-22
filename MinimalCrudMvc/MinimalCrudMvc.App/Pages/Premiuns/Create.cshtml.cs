using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MinimalCrudMvc.App.Data;
using MinimalCrudMvc.App.Models;

namespace MinimalCrudMvc.App.Pages.Premiuns
{
    public class CreateModel : PageModel
    {
        private readonly MinimalCrudMvc.App.Data.ApplicationDbContext _context;

        public CreateModel(MinimalCrudMvc.App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email");
            return Page();
        }

        [BindProperty]
        public Premium Premium { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Premia.Add(Premium);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
