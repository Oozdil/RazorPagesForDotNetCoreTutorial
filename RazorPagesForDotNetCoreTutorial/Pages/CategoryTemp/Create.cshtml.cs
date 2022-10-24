using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesForDotNetCoreTutorial.Data;
using RazorPagesForDotNetCoreTutorial.Model;

namespace RazorPagesForDotNetCoreTutorial.Pages.CategoryTemp
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesForDotNetCoreTutorial.Data.ApplicationDbContext _context;

        public CreateModel(RazorPagesForDotNetCoreTutorial.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
