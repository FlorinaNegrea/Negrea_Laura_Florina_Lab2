﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Negrea_Laura_Florina_Lab2.Data;
using Negrea_Laura_Florina_Lab2.Migrations;
using Negrea_Laura_Florina_Lab2.Models;

namespace Negrea_Laura_Florina_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Negrea_Laura_Florina_Lab2.Data.Negrea_Laura_Florina_Lab2Context _context;

        public CreateModel(Negrea_Laura_Florina_Lab2.Data.Negrea_Laura_Florina_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var authors = _context.Authors.Select(a => new { a.ID, FullName = $"{a.FirstName} {a.LastName}" }).ToList();
            ViewData["AuthorID"] = new SelectList(authors, "ID", "FullName");

            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
            
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
