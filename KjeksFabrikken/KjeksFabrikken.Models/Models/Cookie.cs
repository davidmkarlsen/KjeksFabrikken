using System.ComponentModel.DataAnnotations;
using KjeksFabrikken.ViewModels;

namespace KjeksFabrikken.Models;

public class Cookie
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    
    public string ImgUrl { get; set; }
    
    public virtual ICollection<CookieIngredient> CookieIngredients { get; set; }
    
    public virtual ICollection<CookieCategory> CookieCategories { get; set; }
}