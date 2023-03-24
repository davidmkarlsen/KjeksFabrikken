using System.ComponentModel.DataAnnotations;
using KjeksFabrikken.Models;

namespace KjeksFabrikken.ViewModels;

public class CookieIngredient
{

    [Key]
    public int Id { get; set; }
    
    [Required]
    public int CookieId { get; set; }

    [Required]
    public int IngredientId { get; set; }
    
    public virtual Cookie Cookie { get; set; }
    
    public virtual Ingredient Ingredient { get; set; }
}