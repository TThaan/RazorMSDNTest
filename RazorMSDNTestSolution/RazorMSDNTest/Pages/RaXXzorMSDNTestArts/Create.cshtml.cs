﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorMSDNTest.Data;

namespace RazorMSDNTest.Pages.RaXXzorMSDNTestArts
{
    public class CreateModel : PageModel
    {
        private readonly RazorMSDNTest.Data.RazorMSDNTestArtsDbContext _context;

        public CreateModel(RazorMSDNTest.Data.RazorMSDNTestArtsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RazorMSDNTestArt RazorMSDNTestArt { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RazorMSDNTestArt.Add(RazorMSDNTestArt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
