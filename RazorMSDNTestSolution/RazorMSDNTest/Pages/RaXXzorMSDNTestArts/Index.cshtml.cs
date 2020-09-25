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
    public class IndexModel : PageModel
    {
        private readonly RazorMSDNTest.Data.RazorMSDNTestArtsDbContext _context;

        public IndexModel(RazorMSDNTest.Data.RazorMSDNTestArtsDbContext context)
        {
            _context = context;
        }

        public IList<RazorMSDNTestArt> RazorMSDNTestArt { get;set; }

        public async Task OnGetAsync()
        {
            RazorMSDNTestArt = await _context.RazorMSDNTestArt.ToListAsync();
        }
    }
}
