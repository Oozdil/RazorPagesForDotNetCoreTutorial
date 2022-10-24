using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesForDotNetCoreTutorial.Data;
using RazorPagesForDotNetCoreTutorial.Model;

namespace RazorPagesForDotNetCoreTutorial.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

      
        public async Task<IActionResult> OnPost(Category category)
        {
            if(category.Name==category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(String.Empty,"The Display order cannot be exactly the Name.");
            }



            if(ModelState.IsValid)
            {
                await _db.AddAsync(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category created successfully";

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
