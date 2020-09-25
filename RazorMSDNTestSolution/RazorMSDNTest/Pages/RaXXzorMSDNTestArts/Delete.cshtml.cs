using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMSDNTest.Data;

namespace RazorMSDNTest.Pages.RaXXzorMSDNTestArts
{
    public class DeleteModel : PageModel
    {
        private readonly RazorMSDNTest.Data.RazorMSDNTestArtsDbContext _context;

        public DeleteModel(RazorMSDNTest.Data.RazorMSDNTestArtsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RazorMSDNTestArt RazorMSDNTestArt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RazorMSDNTestArt = await _context.RazorMSDNTestArt.FirstOrDefaultAsync(m => m.ID == id);

            if (RazorMSDNTestArt == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RazorMSDNTestArt = await _context.RazorMSDNTestArt.FindAsync(id);

            if (RazorMSDNTestArt != null)
            {
                _context.RazorMSDNTestArt.Remove(RazorMSDNTestArt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
