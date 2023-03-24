using System.ComponentModel.DataAnnotations;
using KjeksFabrikken.ViewModels;

namespace KjeksFabrikken.Models;

public class Ingredient
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public virtual ICollection<CookieIngredient> CookieIngredients { get; set; }
}