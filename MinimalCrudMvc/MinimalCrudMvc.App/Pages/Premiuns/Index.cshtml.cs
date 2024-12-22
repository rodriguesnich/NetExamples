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
    public class IndexModel : PageModel
    {
        private readonly MinimalCrudMvc.App.Data.ApplicationDbContext _context;

        public IndexModel(MinimalCrudMvc.App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premia
                .Include(p => p.Student).ToListAsync();
        }
    }
}
