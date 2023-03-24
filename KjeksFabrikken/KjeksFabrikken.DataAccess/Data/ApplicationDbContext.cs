using KjeksFabrikken.Models;
using KjeksFabrikken.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace KjeksFabrikken.DataAccess.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Cookie> Cookies { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CookieCategory> CookieCategories { get; set; }
    public DbSet<CookieIngredient> CookieIngredients { get; set; }
    
    
}