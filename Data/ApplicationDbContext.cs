using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MudBlazorWebApp1.Data.Models;

namespace MudBlazorWebApp1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<ProjectCategoryModel> ProjectCategories { get; set; }
    }
}
