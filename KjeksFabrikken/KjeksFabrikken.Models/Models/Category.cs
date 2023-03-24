using System.ComponentModel.DataAnnotations;
using KjeksFabrikken.ViewModels;

namespace KjeksFabrikken.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public virtual ICollection<CookieCategory> CookieCategories { get; set; }
}