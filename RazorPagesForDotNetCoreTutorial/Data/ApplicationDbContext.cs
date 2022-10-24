using Microsoft.EntityFrameworkCore;
using RazorPagesForDotNetCoreTutorial.Model;

namespace RazorPagesForDotNetCoreTutorial.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
