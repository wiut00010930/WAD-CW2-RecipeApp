using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;

namespace RecipeApp.Data
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
