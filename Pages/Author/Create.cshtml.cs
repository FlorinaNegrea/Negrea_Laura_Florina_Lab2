using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Negrea_Laura_Florina_Lab2.Data;
using Negrea_Laura_Florina_Lab2.Models;

namespace Negrea_Laura_Florina_Lab2.Pages.Author
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
            return Page();
        }

        [BindProperty]
        public Authors Authors { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Authors == null || Authors == null)
            {
                return Page();
            }

            _context.Authors.Add(Authors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
